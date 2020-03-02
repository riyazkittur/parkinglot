using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    public class ParkingLot : IParkingLot
    {
        public List<ParkingSlot> ParkingSlots = new List<ParkingSlot>();
        public List<ParkingVehiCleDetails<Vehicle>> ParkedVehicles = new List<ParkingVehiCleDetails<Vehicle>>();
        public const int slotsInEachLevel = 10;
        public const int numberOfLevels = 2;
        public void CreateParkingLot(int numberOfVehicles)
        {

            int levelsRequired;
            if (numberOfVehicles % slotsInEachLevel == 0)
                levelsRequired = numberOfVehicles / slotsInEachLevel;
            else
                levelsRequired = numberOfVehicles / slotsInEachLevel + 1;
           for (int level = 0; level < levelsRequired; level++)
            {
                for (int i = 0; i < slotsInEachLevel; i++)
                {
                    ParkingSlots.Add(new ParkingSlot() { Level=level,SlotNumber = i + 1, IsAvailable = true });
                }
            }
                Console.WriteLine($"Created a parking lot");


        }
        public ParkingSlot GetAvailabeSlotNumber()
        {
            //int availableSlot = -1;
            ParkingSlot availableSlot = ParkingSlots.Where(x => x.IsAvailable == true).FirstOrDefault();
            return availableSlot;

        }
        public void RegisterParking(Vehicle enteredVehicle)
        {

            ParkingSlot availableSlot = GetAvailabeSlotNumber();
            if (availableSlot == null)
            {
                Console.WriteLine("Sorry,parking lot is full");

            }
            else
            {

                ParkingVehiCleDetails<Vehicle> registered = new ParkingVehiCleDetails<Vehicle>()
                {
                    ParkedVehicle = new Car()
                    {
                        RegistrationNumber = enteredVehicle.RegistrationNumber,
                        Color = enteredVehicle.Color
                    },
                    ParkingSlotDetails = availableSlot
                };
                ParkedVehicles.Add(registered);
                ParkingSlots.Where(x => x.SlotNumber == availableSlot.SlotNumber).FirstOrDefault().IsAvailable = false;
                Console.WriteLine($"Allocated slot number: {availableSlot.SlotNumber}");

            }



        }        
        public void ExitParking(ParkingSlot slotToRelease)
        {

            if (!ParkingSlots.Contains(slotToRelease))
            {
                Console.WriteLine("No such slot exists");
            }
            else
            {
                ParkingSlots.Where(x => x.SlotNumber == slotToRelease.SlotNumber).FirstOrDefault().IsAvailable = true;
                ParkingVehiCleDetails<Vehicle> carToRelease = ParkedVehicles.Where(p => p.ParkingSlotDetails == slotToRelease).FirstOrDefault();
                ParkedVehicles.Remove(carToRelease);
                Console.WriteLine($"Slot number {slotToRelease.SlotNumber} in LEVEL {slotToRelease.SlotNumber} is free");
            }

        }
        public void GetParkingLotStatus()
        {
            foreach (ParkingVehiCleDetails<Vehicle> parkingCar in ParkedVehicles)
            {
                Console.WriteLine($"park {parkingCar.ParkedVehicle.RegistrationNumber} {parkingCar.ParkedVehicle.Color} in Level : {parkingCar.ParkingSlotDetails.Level}  Slot:{parkingCar.ParkingSlotDetails.SlotNumber}");
            }
        }
        public void GetParkedVehicleRegisteredNumberByColor(string color)
        {
            var filteredCars = ParkedVehicles.Where(c => c.ParkedVehicle.Color == color)
                 .Select(p => p.ParkedVehicle.RegistrationNumber).ToList<string>();

            if (filteredCars.Count == 0)
            {
                Console.WriteLine("Not Found");
            }
            else
            {
                foreach (string regNumber in filteredCars)
                {
                    Console.WriteLine(regNumber);
                }
            }


        }
        public void GetSlotNumbersByVehicleColor(string color)
        {
            var filteredCars = ParkedVehicles.Where(c => c.ParkedVehicle.Color == color)
               .Select(p => p.ParkingSlotDetails).ToList();

            if (filteredCars.Count == 0)
            {
                Console.WriteLine("Not Found");
            }
            else
            {
                string slots = String.Empty;
                foreach (ParkingSlot slotDetail in filteredCars)
                {
                    slots = slots + "," + slotDetail.Level+"-"+slotDetail.SlotNumber.ToString();
                }
                slots = slots.Substring(1, slots.Length);
                Console.WriteLine(slots);
            }

        }
        public void GetSlotNumberByRegisteredNumber(string registeredNumber)
        {
            var slotDetail = ParkedVehicles.Where(c => c.ParkedVehicle.RegistrationNumber == registeredNumber)
               .Select(p => p.ParkingSlotDetails).FirstOrDefault();

            if (slotDetail== null)
            {
                Console.WriteLine("Not Found");
            }
            else
            {
                Console.WriteLine($"Slot Number for {registeredNumber}: {slotDetail.Level} - {slotDetail.SlotNumber.ToString()}");
            }

        }

    }
    public class ParkingSlot
    {
        public int Level { get; set; }
        public int SlotNumber { get; set; }
        public bool IsAvailable { get; set; }
    }
}
