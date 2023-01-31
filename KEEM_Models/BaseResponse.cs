using KEEM_Models.Enum;

namespace KEEM_Models
{
    public class BaseResponse<T>
    {
        public T Data { get; set; }

        public string Description { get; set; }

        public StatusCode StatusCode { get; set; }
    }
}
