using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class VIPFacade : BaseFacadeDB
    {
        protected static VIPFacade instance = new VIPFacade(new VIPModel());
        protected VIPFacade(VIPModel model) : base(model)
        {
        }
        public static VIPFacade Instance
        {
            get { return instance; }
        }
        protected VIPFacade() : base()
        {
        }
    }
}
