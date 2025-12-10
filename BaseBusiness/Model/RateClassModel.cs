using BaseBusiness.Model;

namespace BaseBusiness.Model
{
    public class RateClassModel : bc.BaseModel
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Inactive { get; set; } = true;
    }
}
