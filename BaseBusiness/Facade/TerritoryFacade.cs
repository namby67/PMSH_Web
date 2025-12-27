using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class TerritoryFacade : BaseFacadeDB
    {
        protected static TerritoryFacade instance = new TerritoryFacade(new TerritoryModel());
        protected TerritoryFacade(TerritoryModel model) : base(model)
        {
        }
        public static TerritoryFacade Instance
        {
            get { return instance; }
        }
        protected TerritoryFacade() : base()
        {
        }
    }
}
