using BaseBusiness.bc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Model
{
    public class MemberTypeModel : BaseModel
    {

        public int ID { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public string Level { get;set; }


        public string Description { get; set; }


        public int MemberCategoryID { get; set; }

   
        public int UserInsertID { get; set; }

   
        public DateTime CreateDate { get; set; }

        public int UserUpdateID { get; set; }

       
        public DateTime UpdateDate { get; set; }

       
        public bool Inactive { get; set; }

       
        public string CreatedBy { get; set; }

        
        public DateTime CreatedDate { get; set; }

        
        public string UpdatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }
    }
}
