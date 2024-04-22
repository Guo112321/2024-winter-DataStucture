using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDS
{
    public class RoomFactory
    {
        public IRoom GetRoom(string roomType, string roomNum)
        {
            switch(roomType)
            {
                case "standard":
                    return new StandardRoom(roomNum);
                case "business":
                    return new BusinessRoom(roomNum);
                case "suite":
                    return new SuiteRoom(roomNum);
                default:
                    throw new ArgumentException("Invalid room type");
            }
        }
    }
}
