using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class ARAgingLevelsFacade : BaseFacadeDB
    {
        protected static ARAgingLevelsFacade instance = new ARAgingLevelsFacade(new ARAgingLevelsModel());
        protected ARAgingLevelsFacade(ARAgingLevelsModel model) : base(model)
        {
        }
        public static ARAgingLevelsFacade Instance
        {
            get { return instance; }
        }
        protected ARAgingLevelsFacade() : base()
        {
        }
    }
}
