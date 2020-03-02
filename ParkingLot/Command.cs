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
       

        public void Execute(ref ParkingLot parking, string command)
        {          
            parking.CreateParkingLot(ReadCommand.GetNumberOfVehiclesFromCommand(command));
        }
    }
    public class Park: ICommand
    {
       
        public void Execute(ref ParkingLot parking, string command)
        {
          
            parking.RegisterParking(ReadCommand.GetVehicleFromCommand(command));
        }
    }

    public class Leave : ICommand
    {
       
        public void Execute(ref ParkingLot parking, string command)
        {
            int slotToRelease = ReadCommand.GetParkingSlotFromCommand(command);
           ParkingSlot parkingSlot = parking.ParkingSlots.Where(s => s.SlotNumber == slotToRelease).FirstOrDefault();
            parking.ExitParking(parkingSlot);
        }
    }

    public class CheckStatus : ICommand
    {
        public void Execute(ref ParkingLot parking, string command)
        {
            parking.GetParkingLotStatus();
        }
    }
    public class GetSlotsByColor : ICommand
    {
     
        public void Execute(ref ParkingLot parking, string command)
        {
            parking.GetSlotNumbersByVehicleColor(ReadCommand.GetColorFromCommand(command));
        }
    }
    public class GetSlotsByRegisteredNumber : ICommand
    {
      
        public void Execute(ref ParkingLot parking, string command)
        {
            parking.GetSlotNumberByRegisteredNumber(ReadCommand.GetRegisteredNumberFromCommand(command));
        }
    }
    public class GetRegisteredNumberByColor : ICommand
    {
       
        public void Execute(ref ParkingLot parking, string command)
        {
            parking.GetParkedVehicleRegisteredNumberByColor(ReadCommand.GetColorFromCommand(command));
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
