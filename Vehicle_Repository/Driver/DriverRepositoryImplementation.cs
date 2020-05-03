using Bogus.DataSets;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Repository.Driver
{
    public class DriverRepositoryImplementation : IDriverRepository
    {
        private readonly VehicleDBContext vehicleDBContext;
        public static List<Vehicle> vehiclelist = new List<Vehicle>(50);
        public DriverRepositoryImplementation(VehicleDBContext vehicleDBContext )

        {
            this.vehicleDBContext = vehicleDBContext;
        }
        /// <summary>
        /// adding the employee in the database
        /// </summary>
        /// <returns></returns>

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


        public Vehicle GetVehicle(int ParkingSlotNumber)
        {
            
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

        public Vehicle RemoveParking(int ParkingSlotNumber)
        {
            throw new NotImplementedException();
        }
    }
}
