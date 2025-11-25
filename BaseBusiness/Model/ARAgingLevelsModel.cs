using BaseBusiness.bc;
namespace BaseBusiness.Model
{
    public class ARAgingLevelsModel : BaseModel
    {
        public int ID { get; set; }

        public string Levels { get; set; }

        public int AgingValue { get; set; }

        public string Description { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }
    }
}
