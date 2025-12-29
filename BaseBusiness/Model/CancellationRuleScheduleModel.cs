using BaseBusiness.bc;

namespace BaseBusiness.Model
{
    public class CancellationRuleScheduleModel : BaseModel
    {
        public int ID { get; set; }
        public int CancellationRuleID { get; set; }
        public int RateCodeID { get; set; }
        public int ReservationTypeID { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Sequence { get; set; }
        public bool Override { get; set; }
        public bool Inactive { get; set; }
        public int UserInsertID { get; set; }
        public int UserUpdateID { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsDelete { get; set; }
        public string DaysOfWeek { get; set; }

    }
}
