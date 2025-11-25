using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomManagement.Dto
{
    public class BusinessBlockDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public byte Action { get; set; }
        public DateTime CutOffDate { get; set; }
        public int CutOffDays { get; set; }
        public int SourceRoomInventoryID { get; set; }
        public int DestinationRoomInventoryID { get; set; }
        public int Status { get; set; }
        public string StatusCode { get; set; }
        public int StatusLevel { get; set; }
        public int BookingTypeID { get; set; }
        public bool IsMaster { get; set; }
        public int MarketID { get; set; }
        public int PackageID { get; set; }
        public int ReservationTypeID { get; set; }
        public int RateCodeID { get; set; }
        public bool IsFinishTrace { get; set; }
        public int RoomID { get; set; }
        public string RoomNo { get; set; }
        public DateTime FromDateOOO { get; set; }
        public DateTime ToDateOOO { get; set; }
        public byte OOOStatus { get; set; }
        public int ReasonID { get; set; }
        public int BlockTraceID { get; set; }
        public DateTime CreateDate { get; set; }
        public int UserUpdateID { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UserInsertID { get; set; }
        public int BusinessBlockID { get; set; }
        public bool IsBB { get; set; }
        public int ReturnStatus { get; set; }
        public string Completed { get; set; }
        public string ReasonNote { get; set; }
        public string TourCode { get; set; }
    }
}
