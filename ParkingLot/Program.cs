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
            if (ReadCommand.IsValidCommand(command))
            {
                Enum.TryParse(ReadCommand.GetCommandKeyWord(command), out UserCommand userCommand);
                commandObject = commandFactory.GetCommandObject(userCommand);
                commandObject.Execute(ref carParkingLot, command);
            }
            else
            {
                Console.WriteLine("Invalid Command");
            }
            
            goto ReadCommand;
            
        }
       


    }
}
