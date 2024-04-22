using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDS
{
    public class SuiteRoom : IRoom
    {
        public string RoomNum { get; private set; }

        public string Description => "Suite Room";

        public int BedCount => 3;

        public bool IsBooked { get; set; }

        public void BookRoom()
        {
            IsBooked = true;
        }

        public double Cost()
        {
            return 250;
        }

        public void ReleaseRoom()
        {
            IsBooked = false;
        }

        public SuiteRoom(string roomNum)
        {
            RoomNum = roomNum;
            IsBooked = false ;
        }
    }
}
