using BaseBusiness.bc;

namespace BaseBusiness.Model
{
    public class PackageForecastGroupModel : BaseModel
    {
        public int ID { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

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
