using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class FolioFacade : BaseFacadeDB
    {
        protected static FolioFacade instance = new FolioFacade(new FolioModel());
        protected FolioFacade(FolioModel model) : base(model)
        {
        }
        public static FolioFacade Instance
        {
            get { return instance; }
        }
        protected FolioFacade() : base()
        {
        }
    }
}
