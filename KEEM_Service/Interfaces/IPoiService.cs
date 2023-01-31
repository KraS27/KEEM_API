using KEEM_Models;
using KEEM_Models.Tables;

namespace KEEM_Service.Interfaces
{
    public interface IPoiService
    {
        Task<BaseResponse<IEnumerable<Poi>>> GetAllPois();
    }
}
