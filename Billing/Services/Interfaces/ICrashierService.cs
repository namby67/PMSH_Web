using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing.Services.Interfaces
{
    public interface ICrashierService
    {
        ShiftModel Login(string LoginName, string Password);
    }
}
