using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    public interface ICommand
    {
        void Execute(ref ParkingLot parking,string command);
    }
    public class CreateParkingLot : ICommand
    {
        public int GetNumberOfVehiclesFromCommand(string command)
        {
            string[] commandDetails=command.Split(' ');
            return int.Parse(commandDetails[1]);
        }

        public void Execute(ref ParkingLot parking, string command)
        {          
            parking.CreateParkingLot(GetNumberOfVehiclesFromCommand(command));
        }
    }
    public class Park: ICommand
    {
        public Vehicle GetVehicleFromCommand(string command)
        {
            string[] commandDetails = command.Split(' ');
            Vehicle enteredCar = new Car()
            {
                RegistrationNumber = commandDetails[1],
                Color = commandDetails[2]
            };
            return enteredCar;

        }
        public void Execute(ref ParkingLot parking, string command)
        {
          
            parking.RegisterParking(GetVehicleFromCommand(command));
        }
    }

    public class Leave : ICommand
    {
        public int GetParkingSlotFromCommand(string command)
        {
            string[] commandDetails = command.Split(' ');
           return int.Parse(commandDetails[1]);
            
        }
        public void Execute(ref ParkingLot parking, string command)
        {
            int slotToRelease = GetParkingSlotFromCommand(command);
           ParkingSlot parkingSlot = parking.ParkingSlots.Where(s => s.SlotNumber == slotToRelease).FirstOrDefault();
            parking.ExitParking(parkingSlot);
        }
    }
    //public class RequestHandle
    //{
    //    private Dictionary<int, ICommand> CommandMap;
    //    public void HandleRequest(int action)
    //    {
    //        ICommand command = CommandMap[action];
    //        command.Execute();
    //    }

    //}


}
