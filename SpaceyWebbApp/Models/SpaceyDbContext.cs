using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceyWebbApp.Models
{
    public class SpaceyDbContext : DbContext
    {
        public SpaceyDbContext(DbContextOptions<SpaceyDbContext> options) :base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Rocket> Rockets { get; set; }
        public DbSet<Expedition> Expeditions { get; set; }
    }
}
