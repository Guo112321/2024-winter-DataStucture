using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDS
{
    public class BusinessRoom : IRoom
    {
        public string RoomNum { get; private set; }

        public string Description => "Business Room";

        public int BedCount => 2;

        public bool IsBooked { get; set; }

        public void BookRoom()
        {
            IsBooked = true;
        }

        public double Cost()
        {
            return 150;
        }

        public void ReleaseRoom()
        {
            IsBooked = false;
        }

        public BusinessRoom(string roomNum)
        {
            RoomNum = roomNum;
            IsBooked = false ;
        }
    }
}
