using BaseBusiness.bc;
using BaseBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Facade
{
    public class ContactEmailTemplateFacade : BaseFacadeDB
    {
        protected static ContactEmailTemplateFacade instance = new ContactEmailTemplateFacade(new ContactEmailTemplateModel());
        protected ContactEmailTemplateFacade(ContactEmailTemplateModel model) : base(model)
        {
        }
        public static ContactEmailTemplateFacade Instance
        {
            get { return instance; }
        }
        protected ContactEmailTemplateFacade() : base()
        {
        }
    }
}
