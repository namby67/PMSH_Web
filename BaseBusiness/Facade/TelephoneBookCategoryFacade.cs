using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseBusiness.bc;
using BaseBusiness.Model;

namespace BaseBusiness.Facade
{
    public class TelephoneBookCategoryFacade : BaseFacadeDB
    {
        protected static TelephoneBookCategoryFacade instance = new TelephoneBookCategoryFacade(new TelephoneBookCategoryModel());
        protected TelephoneBookCategoryFacade(TelephoneBookCategoryModel model) : base(model)
        {
        }
        public static TelephoneBookCategoryFacade Instance
        {
            get { return instance; }
        }
        protected TelephoneBookCategoryFacade() : base()
        {
        }
    }
}
