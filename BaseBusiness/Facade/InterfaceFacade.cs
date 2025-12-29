using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class InterfaceFacade : BaseFacadeDB
    {
        protected static InterfaceFacade instance = new InterfaceFacade(new InterfaceModel());
        protected InterfaceFacade(InterfaceModel model) : base(model)
        {
        }
        public static InterfaceFacade Instance
        {
            get { return instance; }
        }
        protected InterfaceFacade() : base()
        {
        }
    }
}
