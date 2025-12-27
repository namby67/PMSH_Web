using BaseBusiness.bc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Model
{
    public class ContactEmailTemplateModel : BaseModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public int Language { get; set; }
    }
}
