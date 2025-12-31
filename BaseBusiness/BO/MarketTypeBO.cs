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
    public class MarketTypeBO : BaseBO
    {
        private MarketTypeFacade facade = MarketTypeFacade.Instance;
        protected static MarketTypeBO instance = new MarketTypeBO();

        protected MarketTypeBO()
        {
            this.baseFacade = facade;
        }

        public static MarketTypeBO Instance
        {
            get { return instance; }
        }
    }
}
