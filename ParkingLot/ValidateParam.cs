using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    public class ValidateParam
    {
        public Dictionary<UserCommand,int> CommandParam { get; set; }
        public ValidateParam()
        {
            CommandParam = new Dictionary<UserCommand, int>
            {
                {UserCommand.create_parking_lot, 1 },
                {UserCommand.leave, 1 },
                {UserCommand.park, 3 },
                {UserCommand.registration_numbers_for_cars_with_colour, 1 },
                {UserCommand.slot_numbers_for_cars_with_colour, 1 },
                {UserCommand.slot_number_for_registration_number, 1 },
                {UserCommand.status,0 }
            };
            

        }
        public bool IsValidCommand(string command)
        {
            string[] commandDetails = command.Split(' ');
            bool IsValid = Enum.TryParse(ReadCommand.GetCommandKeyWord(command), out UserCommand userCommand);
            if (IsValid)
            {
                int paramCount = CommandParam[userCommand];
                return (commandDetails.Length == (paramCount + 1));
            }
            else
            {
                return IsValid;
            }
        }
    }
}
