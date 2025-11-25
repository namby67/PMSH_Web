using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseBusiness.bc;
using BaseBusiness.Model;

namespace BaseBusiness.Facade
{
    public class PickupDropPlaceFacade : BaseFacadeDB
    {
        protected static PickupDropPlaceFacade instance = new PickupDropPlaceFacade(new PickupDropPlaceModel());
        protected PickupDropPlaceFacade(PickupDropPlaceModel model) : base(model)
        {
        }
        public static PickupDropPlaceFacade Instance
        {
            get { return instance; }
        }
        protected PickupDropPlaceFacade() : base()
        {
        }
    }
}
