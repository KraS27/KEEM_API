using KEEM_DAL.Interfaces;
using KEEM_DAL.Repositories;
using KEEM_Models;
using KEEM_Models.Tables;
using KEEM_Models.ViewModels;
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

        public async Task<BaseResponse<IEnumerable<PoiVM>>> GetAllPois()
        {
            try
            {
                var pois = await _poiRepository.GetAll().Include(p => p.OwnerType).ToListAsync();

                var poisVM = new List<PoiVM>();

                foreach (var poi in pois)
                {
                    poisVM.Add(new PoiVM
                    {
                        Id = poi.Id,
                        IdOfUser = poi.IdOfUser,
                        Type = poi.Type,
                        OwnerType = poi.OwnerType.Type,                        
                        CoordLat= poi.CoordLat,
                        CoordLng= poi.CoordLng,
                        Description= poi.Description,
                        NameObject = poi.NameObject
                    });
                }

                if (pois.Count != 0)
                {
                    return new BaseResponse<IEnumerable<PoiVM>>()
                    {
                        Data = poisVM,
                        StatusCode = KEEM_Models.Enum.StatusCode.Ok
                    };
                }
                else
                {
                    return new BaseResponse<IEnumerable<PoiVM>>()
                    {
                        StatusCode = KEEM_Models.Enum.StatusCode.NotFound,                       
                    };
                }
            }
            catch(Exception ex)
            {
                return new BaseResponse<IEnumerable<PoiVM>>
                {
                    StatusCode = KEEM_Models.Enum.StatusCode.InternalServerError,
                    Description = $"[GetAllPois] + {ex.Message}"
                };
            }       
        }
    }
}
        
    

