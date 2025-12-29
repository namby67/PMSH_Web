using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class lafQualityTypeBO : BaseBO
    {
        private lafQualityTypeFacade facade = lafQualityTypeFacade.Instance;
        protected static lafQualityTypeBO instance = new lafQualityTypeBO();

        protected lafQualityTypeBO()
        {
            this.baseFacade = facade;
        }

        public static lafQualityTypeBO Instance
        {
            get { return instance; }
        }
    }
}
