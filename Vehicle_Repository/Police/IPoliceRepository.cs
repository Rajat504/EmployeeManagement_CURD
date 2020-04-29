using Bogus.DataSets;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Repository.Police
{
   public interface IPoliceRepository
   {
        string GetParkingSpace();
        IEnumerable<Vehicle> GetVehicles();
        Task<int> AddParking(Vehicle vehicle);
        Vehicle RemoveParking(int ParkingSlotNumber);
        double ParkingCharge(int ParkingSlotNumber);
   }
}
