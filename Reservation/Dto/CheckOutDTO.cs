using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Dto
{
    public class CheckOutDTO
    {
        public string roomNo { get; set; }
        public string mg { get; set; }
        public string reservationStatus { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string coStatus { get; set; }
        public string message { get; set; }
    }
}
