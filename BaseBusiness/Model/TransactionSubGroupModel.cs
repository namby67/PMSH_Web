using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseBusiness.bc;

namespace BaseBusiness.Model
{
    public class TransactionSubGroupModel : BaseModel
    {
 
        public int ID { get; set; }   
        public string Code { get; set; }   
        public string Description { get; set; }  
        public int TransactionGroupID { get; set; }  
        public int GenerateID { get; set; }   
        public int Seq { get; set; }   
        public DateTime CreateDate { get; set; }   
        public DateTime UpdateDate { get; set; }   
        public int UserInsertID { get; set; }   
        public int UserUpdateID { get; set; }  
    }
}

