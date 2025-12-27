using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administration.Services.Interfaces
{
    public interface IEmailService
    {
        public DataTable GetAllEmailOfGuest(DateTime fromDate, DateTime toDate, int status);
        //void SendEmail(string hoTen, string email, string body, string orderCode);
    }
}
