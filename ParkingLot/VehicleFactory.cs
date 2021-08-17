using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    public static class VehicleFactory
    {
        public static Vehicle GetVehicle(VehicleType vehicleType)
        {
            switch (vehicleType)
            {
                case VehicleType.Motorcycle:
                    return new Motorcycle()
                    {
                        MinimumParkingFee = 10,
                        MinimumParkingHours = 3,
                        ParkingFeePerHour = 10f
                    };
                        
                case VehicleType.Car:
                    return new Car()
                    {
                        MinimumParkingFee = 30,
                        MinimumParkingHours = 2,
                        ParkingFeePerHour = 50f
                    }; ;
                case VehicleType.Bus:
                    return new Bus()
                    {
                        MinimumParkingFee = 50,
                        MinimumParkingHours = 1,
                        ParkingFeePerHour = 75f
                    }; ;
                default:
                    return new Vehicle()
                    {
                        MinimumParkingFee = 10,
                        MinimumParkingHours = 3,
                        ParkingFeePerHour = 10f
                    }; ;
            }
                
        }
    }

    public enum VehicleType
    {
        Motorcycle=0,
        Car,
        Bus

    }
}
