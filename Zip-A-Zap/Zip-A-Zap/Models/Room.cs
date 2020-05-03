using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zip_A_Zap.Models
{
    public class Room
    {

        public string Username { get; set; }
        public string location { get; set; }
        public int RoomNumber { get; set; }
        public string RoomType { get; set; }

        public int PersonsPrrRoom { get; set; }
        public DateTime CheckIn{ get; set; }
        public DateTime CheckOut { get; set; }

    }
}