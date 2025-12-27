using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Profile.Services.Interfaces
{
    public interface IFutureService
    {
        public DataTable SearchProfileFuture(int profileID, int profileType);
    }
}
