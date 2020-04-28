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
        public static List<Vehicle> vehiclelist = new List<Vehicle>(20);
        public IDriverRepositoryImplementation(VehicleDBContext vehicleDBContext )

        {
            this.vehicleDBContext = vehicleDBContext;
        }

        public string GetParkingSpace()
        {
            int list = 0;
            while(list<vehiclelist.Count||)

        }

        public Vehicle GetVehicle(int ParkingSlotNumber)
        {
            throw new NotImplementedException();
        }

        public double ParkingCharge(int ParkingSlotNumber)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Vehicle> GetVehicles()
        {
            throw new NotImplementedException();
        }

        public Task<int> AddParking(Vehicle vehicle)
        {
            throw new NotImplementedException();
        }
    }
}
