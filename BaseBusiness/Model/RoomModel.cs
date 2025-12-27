using BaseBusiness.bc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness.Model
{
    public class RoomModel : BaseModel
    {
        public int ID { get; set; }
        public string RoomNo { get; set; }
        public string RoomName { get; set; }
        public string  Floor { get; set; }
        public int RoomTypeID { get; set; }
        public string RoomTypeCode { get; set; }
        public int ZoneID { get; set; }
        public int RoomDirectionID { get; set; }
        public int PhoneExtension { get;set; }
        public string Description { get; set; }
        public int Smoking { get; set; }
        public int HKStatusID { get; set; }
        public int RoomStatus { get; set; }
        public int FOStatus { get; set; }
        public int STOCredit { get; set; }
        public int DepCredit { get; set; }
        public int PickUpCredit { get; set; }
        public int HKPersons { get; set;}
        public int ConnectingRoomID { get; set; }
        public string SquareUnits {  get; set; }
        public string Measurements {  get; set; }
        public int Feature {  get; set; }
        public int OccupancyMax {  get; set; }
        public string KeyCode {  get; set; }
        public int PrfFloorID {  get; set; }
        public int PrfSmokingID {  get; set; }
        public string NextBlock {  get; set; }
        public int FOPerson {  get; set; }
        public int HKFOStatus { get; set; }
        public bool IsBalcony {  get; set; }
        public string Image { get; set; }
        public int DaySectionID {  get; set; }
        public int EveningSectionID {  get; set; }
        public int CurrResvStatus {  get; set; }
        public int UserInsertID { get; set; }
        public DateTime CreateDate {  get; set; }
        public DateTime UpdateDate { get; set; }
        public int UserUpdateID {  get; set; }
        public string ConnectingRoomNo { get; set; }
        public int TurndownStatus { get;set; }
        public int GuestServiceStatus { get;set;}
        public bool HasExtraBed {  get; set; }
        public string MainGuestNationality { get;set; }
        public int MaxRoomNight { get; set; }
        public int Surcharge { get;set ; }
        public int IsLock {  get; set; }
        public int BlockID { get; set; }
        public string TransactionCode {  get; set; }
    }
}
