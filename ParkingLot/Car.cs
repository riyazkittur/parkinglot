using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    public class Car : Vehicle
    {
       
    }
    public  class Vehicle
    {
        public string RegistrationNumber { get; set; }
        public string Color { get; set; }
        public DateTime EntryDateTime { get; set; }
        public float MinimumParkingFee { get; set; }
        public int MinimumParkingHours { get; set; }
        public float ParkingFeePerHour { get; set; }
        public virtual float BillAmount()
        {
            int hoursParked = (DateTime.Now - EntryDateTime).Hours;
            if (hoursParked <= MinimumParkingHours)
            {
                return MinimumParkingFee;
            }
            else
            {
                hoursParked -= MinimumParkingHours;
                return (MinimumParkingFee + (hoursParked / 60 * ParkingFeePerHour));
            }
            
        }

    }
    public class Motorcycle : Vehicle
    {
       
    }
    public class Bus : Vehicle
    {

    }
}
