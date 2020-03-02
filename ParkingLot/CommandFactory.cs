using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    public class UserCommandFactory
    {
        private Dictionary<int, ICommand> CommandMap;
        public UserCommandFactory()
        {
            CommandMap = new Dictionary<int, ICommand>();
            CommandMap.Add((int)UserCommand.create_parking_lot, new CreateParkingLot());
            CommandMap.Add((int)UserCommand.park, new Park());
            CommandMap.Add((int)UserCommand.leave, new Leave());
            CommandMap.Add((int)UserCommand.status, new CheckStatus());
            CommandMap.Add((int)UserCommand.registration_numbers_for_cars_with_colour, new GetRegisteredNumberByColor());
            CommandMap.Add((int)UserCommand.slot_numbers_for_cars_with_colour, new GetSlotsByColor());
            CommandMap.Add((int)UserCommand.slot_number_for_registration_number, new GetSlotsByRegisteredNumber());
        }

        public ICommand GetCommandObject(UserCommand command)
        {
            int key = (int)command;
            return CommandMap[key];
        }
    }
}
