using KEEM_Models;
using KEEM_Models.ViewModels;

namespace KEEM_Service.Interfaces
{
    public interface IPoiService
    {
        Task<BaseResponse<IEnumerable<PoiVM>>> GetAllPois();
    }
}
