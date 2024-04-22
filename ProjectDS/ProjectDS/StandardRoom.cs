using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDS
{
    public class StandardRoom : IRoom
    {
        public string RoomNum { get; private set; }

        public string Description => "Standard Room";

        public int BedCount => 1;

        public bool IsBooked { get; set; }

        public void BookRoom()
        {
            IsBooked = true;
        }

        public double Cost()
        {
            return 100;
        }

        public void ReleaseRoom()
        {
            IsBooked = false;
        }

        public StandardRoom(string roomNumber)
        {
            RoomNum = roomNumber;
            IsBooked = false ;
        }
    }
}
