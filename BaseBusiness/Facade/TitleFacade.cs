using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class TitleFacade : BaseFacadeDB
    {
        protected static TitleFacade instance = new TitleFacade(new TitleModel());
        protected TitleFacade(TitleModel model) : base(model)
        {
        }
        public static TitleFacade Instance
        {
            get { return instance; }
        }
        protected TitleFacade() : base()
        {
        }
    }
}
