using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseBusiness.bc;
using BaseBusiness.Model;

namespace BaseBusiness.Facade
{
    public class SeasonFacade : BaseFacadeDB
    {
        protected static SeasonFacade instance = new SeasonFacade(new SeasonModel());
        protected SeasonFacade(SeasonModel model) : base(model)
        {
        }
        public static SeasonFacade Instance
        {
            get { return instance; }
        }
        protected SeasonFacade() : base()
        {
        }
    
    }
}
