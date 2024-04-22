using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDS
{
    public class ParkingDecorator : RoomDecorator
    {
        public ParkingDecorator(IRoom room) : base(room) { }

        public override double Cost()
        {
            return room.Cost() + 15;
        }
    }

}
