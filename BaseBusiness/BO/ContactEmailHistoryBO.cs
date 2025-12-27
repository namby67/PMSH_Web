using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class ContactEmailHistoryBO : BaseBO
    {
        private ContactEmailHistoryFacade facade = ContactEmailHistoryFacade.Instance;
        protected static ContactEmailHistoryBO instance = new ContactEmailHistoryBO();

        protected ContactEmailHistoryBO()
        {
            this.baseFacade = facade;
        }

        public static ContactEmailHistoryBO Instance
        {
            get { return instance; }
        }
    }
}
