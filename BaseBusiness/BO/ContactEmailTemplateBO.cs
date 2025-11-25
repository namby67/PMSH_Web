using BaseBusiness.bc;
using BaseBusiness.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.BO
{
    public class ContactEmailTemplateBO : BaseBO
    {
        private ContactEmailTemplateFacade facade = ContactEmailTemplateFacade.Instance;
        protected static ContactEmailTemplateBO instance = new ContactEmailTemplateBO();

        protected ContactEmailTemplateBO()
        {
            this.baseFacade = facade;
        }

        public static ContactEmailTemplateBO Instance
        {
            get { return instance; }
        }
    }
}
