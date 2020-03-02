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
            if (commandDetails.Length < 2)
            {
                return numberOfVehicles;
            }
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
            Vehicle enteredCar=null;
            if (commandDetails.Length == 3)
            {
                enteredCar = new Car()
                {
                    RegistrationNumber = commandDetails[1],
                    Color = commandDetails[2]
                };
            }
             
            return enteredCar;

        }
        public static int GetParkingSlotFromCommand(string command)
        {
            string[] commandDetails = SplitCommand(command);
            bool isNumber = false;
            int slotNumber=0;
            if (commandDetails.Length == 2)
            {
                isNumber = int.TryParse(commandDetails[1], out  slotNumber);
            }
             
            return isNumber ? slotNumber : 0;          
        }
        public static string GetSearchParamFromCommand(string command)
        {
            string[] commandDetails = SplitCommand(command);
            return commandDetails.Length==2?commandDetails[1]:null;
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
        public static bool IsValidCommand(string command)
        {
           
            bool IsValid = Enum.TryParse(ReadCommand.GetCommandKeyWord(command), out UserCommand userCommand);
            return IsValid;

        }

    }
}
