using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class ItemFacade : BaseFacadeDB
    {
        protected static ItemFacade instance = new ItemFacade(new ItemModel());
        protected ItemFacade(ItemModel model) : base(model)
        {
        }
        public static ItemFacade Instance
        {
            get { return instance; }
        }
        protected ItemFacade() : base()
        {
        }
    }
}
