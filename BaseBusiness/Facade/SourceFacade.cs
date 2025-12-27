
using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class SourceFacade : BaseFacadeDB
    {
        protected static SourceFacade instance = new SourceFacade(new SourceModel());
        protected SourceFacade(SourceModel model) : base(model)
        {
        }
        public static SourceFacade Instance
        {
            get { return instance; }
        }
        protected SourceFacade() : base()
        {
        }
    }
}
