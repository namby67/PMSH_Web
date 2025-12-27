using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administration.Services.Interfaces
{
    public interface ITransactionGroupService
    {
        public DataTable SearchTransactionGroup(string groupCode,string description);

    }
}
