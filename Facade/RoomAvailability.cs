using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class RoomAvailability
    {
        public bool HasAvailableRooms(int nights)
        {
            Console.WriteLine("Checking room availability for " + nights + " nights.");
            return true; // Assume there are available rooms
        }
    }
}
