using Bogus.DataSets;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Repository.security
{
   public interface ISecurityRepository
   {
        string GetParkingSpace();
        Task<int> AddParking(Vehicle vehicle);
        IEnumerable<Vehicle> GetVehicles();
        Vehicle GetVehicle(int ParkingSlotNumber);
    }
}
