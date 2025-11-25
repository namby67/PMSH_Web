using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class LanguageFacade : BaseFacadeDB
    {
        protected static LanguageFacade instance = new LanguageFacade(new LanguageModel());
        protected LanguageFacade(LanguageModel model) : base(model)
        {
        }
        public static LanguageFacade Instance
        {
            get { return instance; }
        }
        protected LanguageFacade() : base()
        {
        }
    }
}
