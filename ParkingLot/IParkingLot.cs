using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    public interface IParkingLot
    {

        ParkingSlot GetAvailabeSlotNumber();
        void RegisterParking(Vehicle enteredVehicle);
        //void CreateParkingLotWithSize(int levelNumber,int slotsInLevel);
        void ExitParking(ParkingSlot slotToRelease);
        void GetParkingLotStatus();
        void GetParkedVehicleRegisteredNumberByColor(string color);
        void GetSlotNumbersByVehicleColor(string color);
        void GetSlotNumberByRegisteredNumber(string registeredNumber);
    }
}
