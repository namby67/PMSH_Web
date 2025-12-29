using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseBusiness.bc;
using BaseBusiness.Facade;

namespace BaseBusiness.BO
{
    public class TelephoneBookCategoryBO : BaseBO
    {
        private TelephoneBookCategoryFacade facade = TelephoneBookCategoryFacade.Instance;
        protected static TelephoneBookCategoryBO instance = new TelephoneBookCategoryBO();

        protected TelephoneBookCategoryBO()
        {
            this.baseFacade = facade;
        }

        public static TelephoneBookCategoryBO Instance
        {
            get { return instance; }
        }
    }
}
