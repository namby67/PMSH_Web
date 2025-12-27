using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseBusiness.bc;
using BaseBusiness.Model;

namespace BaseBusiness.Facade
{
    public class PropertyTypeFacade : BaseFacadeDB
    {
       
        protected static PropertyTypeFacade instance = new PropertyTypeFacade(new PropertyTypeModel());
        protected PropertyTypeFacade(PropertyTypeModel model) : base(model)
        {
        }
        public static PropertyTypeFacade Instance
        {
            get { return instance; }
        }
        protected PropertyTypeFacade() : base()
        {
        }
    }
}
