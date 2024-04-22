using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDS
{
    public interface IRoom
    {
        string RoomNum { get; }
        string Description { get; }
        int BedCount { get; }
        bool IsBooked { get; set; }
        double Cost();
        void BookRoom();
        void ReleaseRoom();
    }
}
