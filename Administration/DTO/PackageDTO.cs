namespace Administration.DTO
{
    public class PackageDTO
    {
        // ===== Primary Key =====
        public int ID { get; set; }

        // ===== Main Info =====
        public string? Code { get; set; }

        // Transaction
        public string? TransCode { get; set; }

        // Description
        public string? Description { get; set; }
        public string? DisplayInFolio { get; set; }

        // ===== Forecast / Type =====
        public int ForecastGroupID { get; set; }
        public int Type { get; set; }

        // ===== Attributes =====
        /// <summary>
        /// 1 = Included In Rate
        /// 0 = Add Rate Separate Line
        /// </summary>
        public int DefaultDisplay { get; set; }

        // ===== Meal Info =====
        public bool Breakfast { get; set; }
        public bool Lunch { get; set; }
        public bool Dinner { get; set; }

        // ===== Status =====
        public bool Active { get; set; }

        // ===== Audit =====
        public int UserInsertID { get; set; }
        public int UserUpdateID { get; set; }
    }
}
