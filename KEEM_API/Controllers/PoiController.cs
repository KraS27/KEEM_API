using KEEM_Models.ViewModels;
using KEEM_Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace KEEM_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PoiController : ControllerBase
    {
        private readonly IPoiService _poiService;

        public PoiController(IPoiService poiService)
        {
            _poiService = poiService;
        }

        [HttpGet("GetPois")]
        public async Task<IActionResult> GetPoisAsync()
        {                               
            var pois = await _poiService.GetAllPois();
                        
            if(pois.StatusCode == KEEM_Models.Enum.StatusCode.Ok)            
                return new ObjectResult(pois.Data);            
            else            
                return NotFound();            
        }
    }
}
