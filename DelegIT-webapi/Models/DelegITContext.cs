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
    }
}
