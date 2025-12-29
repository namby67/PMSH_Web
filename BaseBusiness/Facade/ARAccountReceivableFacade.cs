using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class ARAccountReceivableFacade : BaseFacadeDB
    {
        protected static ARAccountReceivableFacade instance = new ARAccountReceivableFacade(new ARAccountReceivableModel());
        protected ARAccountReceivableFacade(ARAccountReceivableModel model) : base(model)
        {
        }
        public static ARAccountReceivableFacade Instance
        {
            get { return instance; }
        }
        protected ARAccountReceivableFacade() : base()
        {
        }
    }
}
