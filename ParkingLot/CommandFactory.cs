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
            CommandMap = new Dictionary<int, ICommand>
            {
                { (int)UserCommand.create_parking_lot, new CreateParkingLot() },
                { (int)UserCommand.park, new Park() },
                { (int)UserCommand.leave, new Leave() },
                { (int)UserCommand.status, new CheckStatus() },
                { (int)UserCommand.registration_numbers_for_cars_with_colour, new GetRegisteredNumberByColor() },
                { (int)UserCommand.slot_numbers_for_cars_with_colour, new GetSlotsByColor() },
                { (int)UserCommand.slot_number_for_registration_number, new GetSlotsByRegisteredNumber() }
            };
        }

        public ICommand GetCommandObject(UserCommand command)
        {
            int key = (int)command;
            return CommandMap[key];
        }
    }
}
