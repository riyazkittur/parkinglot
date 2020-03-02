using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    class Program
    {
      
        static void Main(string[] args)
        {
            string command;

            ParkingLot carParkingLot = new ParkingLot();        
            UserCommandFactory commandFactory = new UserCommandFactory();
            ICommand commandObject;
            Console.WriteLine("Welcome to parking lot");

        ReadCommand:
            command = Console.ReadLine();          
            Enum.TryParse(ReadCommand.GetCommandKeyWork(command), out UserCommand userCommand);
            commandObject = commandFactory.GetCommandObject(userCommand);
            commandObject.Execute(ref carParkingLot, command);
            goto ReadCommand;
            //if (inputCommand == UserCommands.create_parking_lot.ToString())
            //{
            //    int numberOfVehicles = int.Parse(commandDetails[1]);
            //    carParkingLot.CreateParkingLot(numberOfVehicles);

            //    goto ReadCommand;
            //}

            //else if (inputCommand == UserCommands.park.ToString())
            //{
            //    Car enteredCar = new Car()
            //    {
            //        RegistrationNumber = commandDetails[1],
            //        Color = commandDetails[2]
            //    };
            //    carParkingLot.RegisterParking(enteredCar);
            //    goto ReadCommand;
            //}
            //else if (inputCommand == UserCommands.leave.ToString())
            //{
            //    int slotToRelease = int.Parse(commandDetails[1]);
            //    ParkingSlot parkingSlot = carParkingLot.ParkingSlots.Where(s => s.SlotNumber == slotToRelease).FirstOrDefault();
            //    carParkingLot.ExitParking(parkingSlot);
            //    goto ReadCommand;
            //}
            // if (inputCommand == UserCommands.status.ToString())
            //{
            //    carParkingLot.GetParkingLotStatus();
            //    goto ReadCommand;
            //}
            //else if (inputCommand == UserCommands.slot_numbers_for_cars_with_colour.ToString())
            //{
            //    carParkingLot.GetSlotNumbersByVehicleColor(commandDetails[1]);
            //    goto ReadCommand;
            //}
            //else if (inputCommand == UserCommands.slot_number_for_registration_number.ToString())
            //{
            //    carParkingLot.GetSlotNumberByRegisteredNumber(commandDetails[1]);
            //    goto ReadCommand;
            //}
            //else if (inputCommand == UserCommands.registration_numbers_for_cars_with_colour.ToString())
            //{
            //    carParkingLot.GetParkedVehicleRegisteredNumberByColor(commandDetails[1]);
            //    goto ReadCommand;
            //}
            //else if (inputCommand == UserCommands.close.ToString())
            //{
            //    Console.WriteLine("Closing parking lot");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Command");
            //    goto ReadCommand;
            //}


        }
       


    }
}
