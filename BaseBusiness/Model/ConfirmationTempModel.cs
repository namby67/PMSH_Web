using BaseBusiness.bc;

namespace BaseBusiness.Model
{
    public class ConfirmationTempModel : BaseModel
    {
        public int ID { get; set; }
        public string LetterName { get; set; }
        public int RateCodeID { get; set; }
        public string Nationality { get; set; }
        public int GroupBy { get; set; }
        public string Template { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
