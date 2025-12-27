using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseBusiness.bc;
using BaseBusiness.Model;

namespace BaseBusiness.Facade
{
    public class PropertyFacade : BaseFacadeDB
    {
        protected static PropertyFacade instance = new PropertyFacade(new PropertyModel());
        protected PropertyFacade(PropertyModel model) : base(model)
        {
        }
        public static PropertyFacade Instance
        {
            get { return instance; }
        }
        protected PropertyFacade() : base()
        {
        }
    } 
}
