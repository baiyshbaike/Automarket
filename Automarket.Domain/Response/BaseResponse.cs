using Automarket.Domain.Enum;

namespace Automarket.Domain.Response
{
    public class BaseResponse<T> :IBaseRespons<T>
    {
        public string Description { get; set; }
        public StatusCode StatusCode { get; set; }
        public T Data { get; set; }
    }

    public interface IBaseRespons<T>
    {
        T Data { get; }
        StatusCode StatusCode { get; }
    }
}