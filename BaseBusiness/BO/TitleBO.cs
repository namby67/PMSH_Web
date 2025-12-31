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
    public class TitleBO : BaseBO
    {
        private TitleFacade facade = TitleFacade.Instance;
        protected static TitleBO instance = new TitleBO();

        protected TitleBO()
        {
            this.baseFacade = facade;
        }

        public static TitleBO Instance
        {
            get { return instance; }
        }
    }
}
