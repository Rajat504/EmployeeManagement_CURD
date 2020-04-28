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

        public Vehicle GetVehicle(int ParkingSlotNumber)
        {
            return vehicleDBContext.vehicle.Find(ParkingSlotNumber);
        }

        public double ParkingCharge(int ParkingSlotNumber)
        {
            Vehicle vehicle = vehicleDBContext.vehicle.Find(ParkingSlotNumber);
            DateTime Entrytime = vehicle.EntryTime;
            DateTime ExitTime = vehicle.ExitTime;
            double totalhour = (Entrytime - ExitTime).TotalHours;
            if(vehicle.ParkingType.Equals("valletparking", StringComparison.InvariantCultureIgnoreCase)
                && vehicle.drivertype.Equals("ParkingHour", StringComparison.InvariantCultureIgnoreCase))
            {
                return totalhour * 0;
            }
            else if (vehicle.parkingType.Equals("own", StringComparison.InvariantCultureIgnoreCase)
              && vehicle.drivertype.Equals("normal", StringComparison.InvariantCultureIgnoreCase))
                 {
                   if (totalhour < 1)
                   {
                    return 50;
                   }
                   if (vehicle.vehicleType.Equals("twowheeler", StringComparison.InvariantCultureIgnoreCase) && totalhour >= 1)
                   {
                    return totalHour * vehicle.ChargePerHour;
                   }
                   else if (vehicle.vehicleType.Equals("fourwheeler", StringComparison.InvariantCultureIgnoreCase) && totalHour >= 1)
                   {
                    return totalHour * vehicle.chargesPerHr;
                   }

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
