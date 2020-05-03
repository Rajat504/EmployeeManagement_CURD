using Bogus.DataSets;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Repository.Driver
{
   public interface IDriverRepository
   {
        string GetParkingSpace();
        Vehicle GetVehicle(int ParkingSlotNumber);
        Vehicle ParkingCharge(int ParkingSlotNumber);
        IEnumerable<Vehicle> GetVehicles();
        Task<int> AddParking(Vehicle vehicle);
        Vehicle RemoveParking(int ParkingSlotNumber);
        DateTime AddExitTime();

   }
}
