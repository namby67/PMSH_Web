using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class lafQualityTypeFacade : BaseFacadeDB
    {
        protected static lafQualityTypeFacade instance = new lafQualityTypeFacade(new lafQualityTypeModel());
        protected lafQualityTypeFacade(lafQualityTypeModel model) : base(model)
        {
        }
        public static lafQualityTypeFacade Instance
        {
            get { return instance; }
        }
        protected lafQualityTypeFacade() : base()
        {
        }
    }
}
