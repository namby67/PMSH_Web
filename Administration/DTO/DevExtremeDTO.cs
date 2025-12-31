namespace Administration.DTO
{
    public class DevExtremeDTO
    {
        public class DevExtremeSort
        {
            public string Selector { get; set; } = "";
            public bool Desc { get; set; }
        }
        public class DevExtremeGroup
        {
            public string Selector { get; set; } = "";
            public bool Desc { get; set; }
            public bool IsExpanded { get; set; }
        }
    }

}
