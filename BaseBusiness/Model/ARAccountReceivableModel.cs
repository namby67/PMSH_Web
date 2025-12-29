using BaseBusiness.bc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Model
{
    public class ARAccountReceivableModel : BaseModel
    {
        public int ID { get; set; }
        public string AccountNo { get; set; }
        public int AccountTypeID { get; set; }
        public decimal CreditLimit { get; set; }
        public string CurrencyID { get; set; }
        public int ProfileID { get; set; }
        public string AccountName { get; set; }
        public string ContactName { get; set; }
        public string TelePhone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }

        public string Address3 { get; set; }
        public int CityID { get; set; }
        public string PostalCode { get; set; }
        public int CountryID { get; set; }
        public string State { get; set; }
        public string Description { get; set; }
        public bool StatusFlagged { get;set; }
        public bool StatusInactive { get; set; }
        public int PaymentDueDays { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

    }
}
