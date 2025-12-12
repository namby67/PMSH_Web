using BaseBusiness.bc;

namespace BaseBusiness.Model
{
    public class ConfirmationConfigModel : BaseModel
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public string MailUser { get; set; }
        public string MailPassword { get; set; }
        public string ServerName { get; set; }
        public int ServerPort { get; set; }
        public string MailSubject { get; set; }
        public string MailBody { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string MailSubjectENG { get; set; }
        public string MailBodyENG { get; set; }
    }
}
