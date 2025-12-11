namespace Administration.DTO
{
    public class RateCodeDetailDTO
    {
        public class RateCodeDetailInputDto
        {
            public int RateCodeID { get; set; }
            public DateTime? BeginDate { get; set; }
            public DateTime? EndDate { get; set; }
            public string RoomType { get; set; } = "PVT";
            public string TransCode { get; set; } = "1006";
            public string CurrencyID { get; set; } = "USD";
            public int PackageID { get; set; } = 0;

            public decimal A1 { get; set; } = 0;
            public decimal A2 { get; set; } = 0;
            public decimal A3 { get; set; } = 0;
            public decimal A4 { get; set; } = 0;
            public decimal A5 { get; set; } = 0;
            public decimal A6 { get; set; } = 0;

            public decimal C1 { get; set; } = 0;
            public decimal C2 { get; set; } = 0;
            public decimal C3 { get; set; } = 0;

            public int MinLOS { get; set; } = 0;
            public int MaxLOS { get; set; } = 0;
            public int MinRoom { get; set; } = 0;
            public int MaxRoom { get; set; } = 0;
        }

        public class RateCodeDetailOutputDto
        {
            public int ID { get; set; }
            public string RateCode { get; set; } = "";
            public string RoomType { get; set; } = "";
            public DateTime? RateDate { get; set; }
            public int RateCodeID { get; set; }
            public int RoomTypeID { get; set; }

            public decimal A1 { get; set; }
            public decimal A1AfterTax { get; set; }
            public decimal A2 { get; set; }
            public decimal A2AfterTax { get; set; }
            public decimal A3 { get; set; }
            public decimal A3AfterTax { get; set; }
            public decimal A4 { get; set; }
            public decimal A4AfterTax { get; set; }
            public decimal A5 { get; set; }
            public decimal A5AfterTax { get; set; }
            public decimal A6 { get; set; }
            public decimal A6AfterTax { get; set; }

            public decimal C1 { get; set; }
            public decimal C1AfterTax { get; set; }
            public decimal C2 { get; set; }
            public decimal C2AfterTax { get; set; }
            public decimal C3 { get; set; }
            public decimal C3AfterTax { get; set; }

            public decimal AdultExtra { get; set; }
            public decimal AdultExtraTax { get; set; }

            public string TransactionCode { get; set; } = "";
            public string CurrencyID { get; set; } = "";
        }


    }
}
