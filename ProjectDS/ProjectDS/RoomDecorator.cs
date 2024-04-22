using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDS
{
    public abstract class RoomDecorator : IRoom
    {
        public IRoom room;
        public RoomDecorator(IRoom room)
        {
            this.room = room;
        }

        public string RoomNum => room.RoomNum;
        public string Description => room.Description;
        public int BedCount => room.BedCount;
        public bool IsBooked
        {
            get => room.IsBooked;
            set => room.IsBooked = value;
        }

        public abstract double Cost();
        public void BookRoom() => room.BookRoom();
        public void ReleaseRoom() => room.ReleaseRoom();
    }
}
