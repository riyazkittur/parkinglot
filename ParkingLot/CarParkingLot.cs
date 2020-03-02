using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
  public  class CarParkingLot 
    {


        public List<ParkingLot> ParkingLots = null;
        //public List<ParkingVehiCleDetails<Car>>ParkedCars=new List<ParkingVehiCleDetails<Car>>();
             
        //public int GetAvailabeSlotNumber()
        //{
        //    int availableSlot = -1;
        //    foreach (ParkingLot parkingLot in ParkingLots)
        //    {
        //        availableSlot = Array.IndexOf(parkingLot.Slots, 0);
        //        if (availableSlot != -1)
        //            return availableSlot+1;
        //    }                  
        //        return availableSlot;
            
        //}
        //public void RegisterParking(Car enteredCar)
        //{
           
        //        int availableSlot = GetAvailabeSlotNumber();
        //        if (availableSlot == -1)
        //        {
        //            Console.WriteLine("Sorry,parking lot is full");

        //        }
        //        else
        //        {
                   
        //            ParkingVehiCleDetails<Car> registered = new ParkingVehiCleDetails<Car>()
        //            {
        //                ParkedVehicle = new Car()
        //                {
        //                    RegistrationNumber = enteredCar.RegistrationNumber,
        //                    Color = enteredCar.Color
        //                },
        //                ParkingSlotDetails = availableSlot
        //            };
        //            ParkedCars.Insert(availableSlot - 1, registered);
        //            ParkingLots[availableSlot - 1] = 1;
        //            Console.WriteLine($"Allocated slot number: {availableSlot}");

        //        }

            

        //}
        //public void CreateParkingLotWithSize(string[] commandDetails)
        //{
        //    if (commandDetails.Length == 2)
        //    {
        //        int slots = int.Parse(commandDetails[1]);
        //        ParkingLots = new int[slots];
        //        Console.WriteLine($"Created a parking lot with {slots} slots");
        //    }
        //}
        //public void ExitParking(int slotToRelease)
        //{
            
        //    if (slotToRelease > ParkingLots.Length)
        //    {
        //        Console.WriteLine("No such slot exists");
        //    }
        //    else
        //    {
        //        ParkingLots[slotToRelease - 1] = 0;
        //        ParkingVehiCleDetails<Car> carToRelease = ParkedCars.Where(p => p.ParkingSlotDetails == slotToRelease).FirstOrDefault();
        //        ParkedCars.Remove(carToRelease);
        //        Console.WriteLine($"Slot number {slotToRelease} is free");
        //    }

        //}
        //public void GetParkingLotStatus()
        //{
        //    foreach (ParkingVehiCleDetails<Car> parkingCar in ParkedCars)
        //    {
        //        Console.WriteLine($"park {parkingCar.ParkedVehicle.RegistrationNumber} {parkingCar.ParkedVehicle.Color} {parkingCar.ParkingSlotDetails}");
        //    }
        //}
        //public void GetParkedVehicleRegisteredNumberByColor(string color)
        //{
        //   var filteredCars= ParkedCars.Where(c => c.ParkedVehicle.Color == color)
        //        .Select(p => p.ParkedVehicle.RegistrationNumber).ToList<string>();

        //    if (filteredCars.Count == 0)
        //    {
        //        Console.WriteLine("Not Found");
        //    }
        //    else
        //    {
        //        foreach (string regNumber in filteredCars)
        //        {
        //            Console.WriteLine(regNumber);
        //        }
        //    }
           

        //}
        //public void GetSlotNumbersByVehicleColor(string color)
        //{
        //    var filteredCars = ParkedCars.Where(c => c.ParkedVehicle.Color == color)
        //       .Select(p => p.ParkingSlotDetails).ToList<int>();

        //    if (filteredCars.Count == 0)
        //    {
        //        Console.WriteLine("Not Found");
        //    }
        //    else
        //    {
        //        string slots = String.Empty;
        //        foreach (int slotNumber in filteredCars)
        //        {
        //            slots =slots+","+ slotNumber.ToString();
        //        }
        //        Console.WriteLine(slots);
        //    }
           
        //}
        //public void GetSlotNumberByRegisteredNumber(string registeredNumber)
        //{
        //    var slotNumber = ParkedCars.Where(c => c.ParkedVehicle.RegistrationNumber == registeredNumber)
        //       .Select(p => p.ParkingSlotDetails).FirstOrDefault<int>();

        //    if (slotNumber == 0)
        //    {
        //        Console.WriteLine("Not Found");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"Slot Number for {registeredNumber}: {slotNumber}");
        //    }
            
        //}

    }
}
