using Microsoft.EntityFrameworkCore;
using Model_Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Repository
{
    public class VehicleDBContext : DbContext
    {
        public VehicleDBContext(DbContextOptions<VehicleDBContext> options) : base(options)
        {

        }
        public DbSet<Vehicles> Employees
        {
            get;
            set;
        }
    }
}
