using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseBusiness.bc;
using BaseBusiness.Model;
namespace BaseBusiness.Facade
{
    public class TransportTypeFacade : BaseFacadeDB
    {
        protected static TransportTypeFacade instance = new TransportTypeFacade(new TransportTypeModel());
        protected TransportTypeFacade(TransportTypeModel model) : base(model)
        {
        }
        public static TransportTypeFacade Instance
        {
            get { return instance; }
        }
        protected TransportTypeFacade() : base()
        {
        }
    }
}
