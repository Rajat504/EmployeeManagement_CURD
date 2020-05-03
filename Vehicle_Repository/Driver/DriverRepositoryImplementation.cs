using Bogus.DataSets;
using GoogleMapsApi.Entities.Directions.Response;
using Model_Class;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Repository.Driver
{
    public class DriverRepositoryImplementation
    {
        /* private readonly VehicleDBContext vehicleDBContext;
         public static List<Vehicle> vehiclelist = new List<Vehicle>(50);
         public DriverRepositoryImplementation(VehicleDBContext vehicleDBContext)

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


         public Vehicles GetVehicle(int ParkingSlotNumber)
         {
             Vehicles vehicle = new Vehicles
             {
                 VehicleNumber = 12345,
                 ChargePerHour = 20,
                 EntryTime = DateTime.Now,
                 ParkingSlotNumber = 22,
                 VehicleType = "Four-Wheeler",
                 ParkingType="mall parking area",
                 drivertype="cab-driver",
             };

             return vehicle;


         }

         public Vehicles ParkingCharge(int ParkingSlotNumber)
         {
             Vehicles charges = new Vehicles
             {


                 VehicleType = "four-wheeler",


             };
             return charges;
         }

         public IEnumerable<Vehicle> GetVehicles()
         {
             throw new NotImplementedException();
         }

         public Task<int> AddParking(Vehicle vehicle)
         {

             return
         }

         public Vehicle RemoveParking(int ParkingSlotNumber)
         {
             RemoveParking now = RemoveParking.Now;
             return now;
         }
         public DateTime AddExitTime()
         {
             DateTime now = DateTime.Now;
             return now;
         }
     */
    }
}
