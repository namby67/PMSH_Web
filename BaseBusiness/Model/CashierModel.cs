using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseBusiness.bc;

namespace BaseBusiness.Model
{
    public class CashierModel : BaseModel
    {
        public int ID { get; set; }
        public string LoginName { get; set; }
        public string PasswordHash { get; set; }
        public string SaltKey { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public int Sex { get; set; }
        public string JobDescription { get; set; }
        public DateTime BirthOfDate { get; set; }
        public string Telephone { get; set; }
        public string HandPhone { get; set; }
        public string HomeAddress { get; set; }
        public string Resident { get; set; }
        public string PostalCode { get; set; }
        public int DepartmentID { get; set; }
        public int Status { get; set; }
        public string Communication { get; set; }
        public DateTime PassExpireDate { get; set; }
        public bool IsCashier { get; set; }
        public int CashierNo { get; set; }
        public string Email { get; set; }
        public DateTime StartWorking { get; set; }
        public int GroupID { get; set; }
        public int UserInsertID { get; set; }
        public DateTime CreateDate { get; set; }
        public int UserUpdateID { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool PasswordStatus { get; set; }
        public bool IsOnline { get; set; }
        public string ComputerLogin { get; set; }
        public int JobTitleID { get; set; }
        public int UserGroupID { get; set; }
        public string FullName { get; set; }
        public bool IsShow { get; set; }
    }
}
