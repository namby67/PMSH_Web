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
    public class LanguageBO : BaseBO
    {
        private LanguageFacade facade = LanguageFacade.Instance;
        protected static LanguageBO instance = new LanguageBO();

        protected LanguageBO()
        {
            this.baseFacade = facade;
        }

        public static LanguageBO Instance
        {
            get { return instance; }
        }
    }
}
