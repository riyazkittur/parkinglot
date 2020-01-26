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
            string command = String.Empty;
            string[] commandDetails = null;
            string inputCommand = String.Empty;

            CarParkingLot carParkingLot = new CarParkingLot();
            Console.WriteLine("Welcome to parking lot");
                   
        ReadCommand:
            command = Console.ReadLine();
            commandDetails = command.Split(' ');
            inputCommand= commandDetails[0];
            if (inputCommand == UserCommands.create_parking_lot.ToString())
            {
                carParkingLot.CreateParkingLotWithSize(commandDetails);
                goto ReadCommand;
            }

            else if (inputCommand == UserCommands.park.ToString())
            {
                carParkingLot.RegisterParking(commandDetails);
                goto ReadCommand;
            }
            else if (inputCommand == UserCommands.leave.ToString())
            {
                carParkingLot.ExitParking(commandDetails);                   
                goto ReadCommand;              
            }
            else if (inputCommand == UserCommands.status.ToString())
            {
                carParkingLot.GetParkingLotStatus();
                goto ReadCommand;
            }
            else if (inputCommand == UserCommands.slot_numbers_for_cars_with_colour.ToString())
            {
                carParkingLot.GetSlotNumbersByVehicleColor(commandDetails[1]);
                goto ReadCommand;
            }
            else if (inputCommand == UserCommands.slot_number_for_registration_number.ToString())
            {
                carParkingLot.GetSlotNumberByRegisteredNumber(commandDetails[1]);
                goto ReadCommand;
            }
            else if (inputCommand == UserCommands.registration_numbers_for_cars_with_colour.ToString())
            {
                carParkingLot.GetParkedVehicleRegisteredNumberByColor(commandDetails[1]);
                goto ReadCommand;
            }
            else if(inputCommand == UserCommands.close.ToString())
            {
                Console.WriteLine("Closing parking lot");
            }
            else
            {
                Console.WriteLine("Invalid Command");
                goto ReadCommand;
            }


        }
       


    }
}
