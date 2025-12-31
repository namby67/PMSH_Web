using BaseBusiness.bc;

namespace BaseBusiness.Model
{
    public class RhythmPostingModel : BaseModel
    {
        public int ID { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int? UserInsertID { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? UserUpdateID { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool Inactive { get; set; } = false;
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; } = new DateTime(1900, 1, 1);
        public string UpdatedBy { get; set; } = string.Empty;
        public DateTime UpdatedDate { get; set; } = new DateTime(1900, 1, 1);

        // Implement abstract methods from BaseModel
        public override string GetStringID() => ID.ToString();

        public override string GetPrimaryKeyName() => "ID";
    }
}
