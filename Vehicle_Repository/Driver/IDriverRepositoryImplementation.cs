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

      
    }
}
