using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administration.Services.Interfaces
{
    public interface ITransactionSubGroupService
    {
        public DataTable SearchTransactionSubGroup(string groupCode, string description,int groupID);

    }
}
