using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDS
{
    public class BreakfastDecorator : RoomDecorator
    {
        public BreakfastDecorator(IRoom room) : base(room) { }

        public override double Cost()
        {
            return room.Cost() + 20;
        }
    }
}
