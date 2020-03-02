using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    public class ParkingVehiCleDetails<T>
    {
        public T ParkedVehicle { get; set; }
        public ParkingSlot ParkingSlotDetails { get; set; }
    }
}
