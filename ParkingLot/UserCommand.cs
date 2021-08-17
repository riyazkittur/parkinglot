using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    public enum UserCommand
    {
        create_parking_lot=0,
        park,
        leave,
        status,
        registration_numbers_for_cars_with_colour,
        slot_numbers_for_cars_with_colour,
        slot_number_for_registration_number
        
    }
    public  class ReadCommand
    {
        public static int GetNumberOfVehiclesFromCommand(string command)
        {
            string[] commandDetails = SplitCommand(command);
            int numberOfVehicles = 0;
            var isNumber = int.TryParse(commandDetails[1], out  numberOfVehicles);
            return isNumber?numberOfVehicles:0;
        }
        public static string[] SplitCommand(string command)
        {
            return command.Split(' ');
        }
        public static Vehicle GetVehicleFromCommand(string command)
        {
            string[] commandDetails = SplitCommand(command);
            Enum.TryParse(commandDetails[3], out VehicleType vehicleType);
            Vehicle enteredVehicle = VehicleFactory.GetVehicle(vehicleType);
            enteredVehicle.RegistrationNumber = commandDetails[1];
            enteredVehicle.Color = commandDetails[2];
             


            return enteredVehicle;

        }
        public static int GetParkingSlotFromCommand(string command)
        {
            string[] commandDetails = SplitCommand(command);
            bool isNumber = false;
            int slotNumber=0;
           isNumber = int.TryParse(commandDetails[1], out  slotNumber);
         
           return isNumber ? slotNumber : 0;          
        }
        public static string GetSearchParamFromCommand(string command)
        {
            string[] commandDetails = SplitCommand(command);
            return commandDetails[1];
        }
        //public static string GetRegisteredNumberFromCommand(string command)
        //{
        //    string[] commandDetails = SplitCommand(command);
        //    return commandDetails[1];
        //}
        public static string GetCommandKeyWord(string command)
        {
            string[] commandDetails = SplitCommand(command);
            return commandDetails[0];
        }
        //public static bool IsValidCommand(string command)
        //{
           
        //    bool IsValid = Enum.TryParse(ReadCommand.GetCommandKeyWord(command), out UserCommand userCommand);
        //    return IsValid;

        //}

    }
}
