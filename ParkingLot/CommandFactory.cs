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
            CommandMap.Add((int)UserCommands.create_parking_lot, new CreateParkingLot());
            CommandMap.Add((int)UserCommands.park, new Park());
            CommandMap.Add((int)UserCommands.leave, new Leave());
        }

        public ICommand GetCommandObject(UserCommands command)
        {
            int key = (int)command;
            return CommandMap[key];
        }
    }
}
