using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Repository.Owner
{
  public class IOwnerRepoImplementation : IOwnerRepository
  {
        public readonly VehicleDBContext vehicleDBContext;
        public IOwnerRepoImplementation(VehicleDBContext vehicleDBContext)
        {
            this.vehicleDBContext = vehicleDBContext;
        }
        public 


  }
}
