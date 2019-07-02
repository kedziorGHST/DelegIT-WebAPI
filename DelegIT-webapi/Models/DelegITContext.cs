using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DelegIT_webapi.Models
{
    public class DelegITContext:DbContext
    {
        public DelegITContext(DbContextOptions<DelegITContext> options):base(options)
        {
                
        }

        public DbSet<Ride> Rides { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Delegation> Delegations { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Visit> Visits { get; set; }
    }
}
