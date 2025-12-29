using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseBusiness.bc;
using BaseBusiness.Facade;

namespace BaseBusiness.BO
{
    public class TelephoneBookBO : BaseBO
    {
        private TelephoneBookFacade facade = TelephoneBookFacade.Instance;
        protected static TelephoneBookBO instance = new TelephoneBookBO();

        protected TelephoneBookBO()
        {
            this.baseFacade = facade;
        }
        public static TelephoneBookBO Instance
        {
            get { return instance; }
        }

    }
}
