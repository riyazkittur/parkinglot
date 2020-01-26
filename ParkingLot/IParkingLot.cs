using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    public interface IParkingLot
    {

        int GetAvailabeSlotNumber();
        void RegisterParking(string[] carDetails);
        void CreateParkingLotWithSize(string[] commandDetails);
        void ExitParking(string[] commandDetails);
        void GetParkingLotStatus();
        void GetParkedVehicleRegisteredNumberByColor(string color);
        void GetSlotNumbersByVehicleColor(string color);
        void GetSlotNumberByRegisteredNumber(string registeredNumber);
    }
}
