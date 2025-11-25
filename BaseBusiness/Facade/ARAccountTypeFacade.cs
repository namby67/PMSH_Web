using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class ARAccountTypeFacade : BaseFacadeDB
    {
        protected static ARAccountTypeFacade instance = new ARAccountTypeFacade(new ARAccountTypeModel());
        protected ARAccountTypeFacade(ARAccountTypeModel model) : base(model)
        {
        }
        public static ARAccountTypeFacade Instance
        {
            get { return instance; }
        }
        protected ARAccountTypeFacade() : base()
        {
        }
    }
}
