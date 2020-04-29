using Bogus.DataSets;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Repository.Owner
{
   public interface IOwnerRepository
   {
        Task<int> AddParking(Vehicle vehicle);
        Vehicle GetVehicle(int ParkingSlotNumber);
        Vehicle RemoveParking(int ParkingSlotNumber);
    }
}
