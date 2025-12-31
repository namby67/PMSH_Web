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
    public class SourceBO : BaseBO
    {
        private SourceFacade facade = SourceFacade.Instance;
        protected static SourceBO instance = new SourceBO();

        protected SourceBO()
        {
            this.baseFacade = facade;
        }

        public static SourceBO Instance
        {
            get { return instance; }
        }
    }
}
