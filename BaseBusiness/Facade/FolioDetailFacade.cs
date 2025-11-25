using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class FolioDetailFacade : BaseFacadeDB
    {
        protected static FolioDetailFacade instance = new FolioDetailFacade(new FolioDetailModel());
        protected FolioDetailFacade(FolioDetailModel model) : base(model)
        {
        }
        public static FolioDetailFacade Instance
        {
            get { return instance; }
        }
        protected FolioDetailFacade() : base()
        {
        }
    }
}
