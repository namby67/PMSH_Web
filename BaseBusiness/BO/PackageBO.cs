using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class PackageBO : BaseBO
    {
        private PackageFacade facade = PackageFacade.Instance;
        protected static PackageBO instance = new PackageBO();

        protected PackageBO()
        {
            this.baseFacade = facade;
        }

        public static PackageBO Instance
        {
            get { return instance; }
        }
    }
}
