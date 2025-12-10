using System.Data;

namespace Administration.Services
{
    public interface IRateCodeDetailService
    {
        Task<DataTable> RateCodeTypeData();
    }
}
