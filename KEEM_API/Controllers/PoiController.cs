using KEEM_Models.Tables;
using KEEM_Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;

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
        public async Task<IEnumerable<Poi>> GetPoisAsync()
        {
            var pois = await _poiService.GetAllPois();

            if(pois.StatusCode == KEEM_Models.Enum.StatusCode.Ok)
            {
                return pois.Data;
            }
            else
            {
                return null;
            }
        }
    }
}
