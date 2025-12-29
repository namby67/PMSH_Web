using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseBusiness.bc;
using BaseBusiness.Model;

namespace BaseBusiness.Facade
{
    public class TelephoneBookFacade : BaseFacadeDB
    {
        protected static TelephoneBookFacade instance = new TelephoneBookFacade(new TelephoneBookModel());
        protected TelephoneBookFacade(TelephoneBookModel model) : base(model)
        {
        }
        public static TelephoneBookFacade Instance
        {
            get { return instance; }
        }
        protected TelephoneBookFacade() : base()
        {
        }
    }
}
