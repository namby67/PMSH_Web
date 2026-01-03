using System.Data;

namespace Reservation.Services.Interfaces
{
    public interface IAllotmentService
    {
        Task<DataTable> GetAllAllotmentData(string? Code, string? Name, int inactive = 0);
    }
}
