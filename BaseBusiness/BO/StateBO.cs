using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseBusiness.bc;
using BaseBusiness.Facade;
using BaseBusiness.Model;
using Microsoft.Data.SqlClient;
namespace BaseBusiness.BO
{
    using Dapper;
    public class StateBO : BaseBO
    {
        private StateFacade facade = StateFacade.Instance;
        protected static StateBO instance = new StateBO();

        protected StateBO()
        {
            this.baseFacade = facade;
        }

        public static StateBO Instance
        {
            get { return instance; }
        }
    }
}
