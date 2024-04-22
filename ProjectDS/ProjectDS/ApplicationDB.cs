using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDS
{
    public class ApplicationDB
    {
        public static Dictionary<string, IRoom> roomsDatabase = new Dictionary<string, IRoom>();
        public static void InitializeRooms()
        {
            AddRoom(new StandardRoom("S101"));
            AddRoom(new StandardRoom("S102"));
            AddRoom(new StandardRoom("S103"));
            AddRoom(new StandardRoom("S104"));

            AddRoom(new BusinessRoom("B201"));
            AddRoom(new BusinessRoom("B202"));
            AddRoom(new BusinessRoom("B203"));
            AddRoom(new BusinessRoom("B204"));

            AddRoom(new SuiteRoom("SU301"));
            AddRoom(new SuiteRoom("SU302"));
            AddRoom(new SuiteRoom("SU303"));
            AddRoom(new SuiteRoom("SU304"));
        }

        private static void AddRoom(IRoom room)
        {
            roomsDatabase.Add(room.RoomNum, room);
        }

        public static IRoom GetRoom(string roomNumber)
        {
            return roomsDatabase[roomNumber];
        }

        public static void BookRoom(string roomNumber, bool withBreakfast, bool withParking)
        {
            if (roomsDatabase.TryGetValue(roomNumber, out IRoom room))
            {
                if (!room.IsBooked)
                {
                    room.BookRoom();
                    if (withBreakfast)
                    {
                        room = new BreakfastDecorator(room);
                    }
                    if (withParking)
                    {
                        room = new ParkingDecorator(room);
                    }
                    roomsDatabase[roomNumber] = room;
                }
            }
        }

        public static void ReleaseRoom(string roomNumber)
        {
            if (roomsDatabase.TryGetValue(roomNumber, out IRoom room))
            {
                IRoom newRoom = CreateNewRoomInstance(roomNumber, room.Description);
                roomsDatabase[roomNumber] = newRoom;
            }
        }

        private static IRoom CreateNewRoomInstance(string roomNumber, string roomDescription)
        {
            switch (roomDescription)
            {
                case "Standard Room":
                    return new StandardRoom(roomNumber);
                case "Business Room":
                    return new BusinessRoom(roomNumber);
                case "Suite Room":
                    return new SuiteRoom(roomNumber);
                default:
                    throw new ArgumentException("Unknown room type for description: " + roomDescription);
            }
        }


        public static List<string> GetRoomDetails(IRoom room)
        {
            List<string> details = new List<string>();

            if (room != null)
            {
                details.Add($"{room.RoomNum}");
                details.Add($"{room.Description}");
                details.Add($"{room.BedCount}");
                details.Add($"{(room.IsBooked ? "Yes" : "No")}");

                IRoom current = room;
                bool hasBreakfast = false, hasParking = false;
                while (current is RoomDecorator decorator)
                {
                    if (decorator is BreakfastDecorator)
                        hasBreakfast = true;
                    if (decorator is ParkingDecorator)
                        hasParking = true;

                    current = decorator.room;
                }

                details.Add($"{(hasBreakfast ? "Yes" : "No")}");
                details.Add($"{(hasParking ? "Yes" : "No")}");
                details.Add($"Cost: ${room.Cost()}");
            }
            else
            {
                details.Add("Room not found.");
            }

            return details;
        }


    }
}
