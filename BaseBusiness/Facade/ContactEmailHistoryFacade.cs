using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class ContactEmailHistoryFacade : BaseFacadeDB
    {
        protected static ContactEmailHistoryFacade instance = new ContactEmailHistoryFacade(new ContactEmailHistoryModel());
        protected ContactEmailHistoryFacade(ContactEmailHistoryModel model) : base(model)
        {
        }
        public static ContactEmailHistoryFacade Instance
        {
            get { return instance; }
        }
        protected ContactEmailHistoryFacade() : base()
        {
        }
    }
}
