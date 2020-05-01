using Bogus.DataSets;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Repository.Driver
{
    public class IDriverRepositoryImplementation : IDriverRepository
    {
        private readonly VehicleDBContext vehicleDBContext;
        public static List<Vehicle> vehiclelist = new List<Vehicle>(50);
        public IDriverRepositoryImplementation(VehicleDBContext vehicleDBContext )

        {
            this.vehicleDBContext = vehicleDBContext;
        }

        public string GetParkingSpace()
        {
            int list = 0;
            while (list < vehiclelist.Count || vehiclelist[list] != null)
            {
                list++;
            }
            if (list == vehiclelist.Count)
                return "lot is full";
            return "lot is emplty";

        }

        string IDriverRepository.GetParkingSpace()
        {
          
        }

        Vehicle IDriverRepository.GetVehicle(int ParkingSlotNumber)
        {
            throw new NotImplementedException();
        }

        double IDriverRepository.ParkingCharge(int ParkingSlotNumber)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Vehicle> IDriverRepository.GetVehicles()
        {
            throw new NotImplementedException();
        }

        Task<int> IDriverRepository.AddParking(Vehicle vehicle)
        {
            throw new NotImplementedException();
        }

        Vehicle IDriverRepository.RemoveParking(int ParkingSlotNumber)
        {
            throw new NotImplementedException();
        }
    }
}
