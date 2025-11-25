using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class PackageFacade : BaseFacadeDB
    {
        protected static PackageFacade instance = new PackageFacade(new PackageModel());
        protected PackageFacade(PackageModel model) : base(model)
        {
        }
        public static PackageFacade Instance
        {
            get { return instance; }
        }
        protected PackageFacade() : base()
        {
        }
    }
}
