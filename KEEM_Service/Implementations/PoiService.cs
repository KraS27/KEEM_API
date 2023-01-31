using KEEM_DAL.Interfaces;
using KEEM_DAL.Repositories;
using KEEM_Models;
using KEEM_Models.Tables;
using KEEM_Service.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace KEEM_Service.Implementations
{
    public class PoiService : IPoiService
    {
        private readonly IBaseRepository<Poi> _poiRepository;

        public PoiService(IBaseRepository<Poi> poiRepository)
        {
            _poiRepository = poiRepository;
        }

        public async Task<BaseResponse<IEnumerable<Poi>>> GetAllPois()
        {
            try
            {
                var pois = await _poiRepository.GetAll().ToListAsync();

                if (pois.Count != 0)
                {
                    return new BaseResponse<IEnumerable<Poi>>()
                    {
                        Data = pois,
                        StatusCode = KEEM_Models.Enum.StatusCode.Ok
                    };
                }
                else
                {
                    return new BaseResponse<IEnumerable<Poi>>()
                    {
                        StatusCode = KEEM_Models.Enum.StatusCode.NotFound,                       
                    };
                }
            }
            catch(Exception ex)
            {
                return new BaseResponse<IEnumerable<Poi>>
                {
                    StatusCode = KEEM_Models.Enum.StatusCode.InternalServerError,
                    Description = $"[GetAllPois] + {ex.Message}"
                };
            }       
        }
    }
}
        
    

