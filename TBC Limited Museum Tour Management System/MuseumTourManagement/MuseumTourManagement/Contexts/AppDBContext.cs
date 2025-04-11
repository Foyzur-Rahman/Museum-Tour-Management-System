using Microsoft.EntityFrameworkCore;
using MuseumTourManagement.Database;
using MuseumTourManagement.Models; // Ensure it matches your namespace

namespace MuseumTourManagement.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Expedition> Expeditions { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-IJNILMU;Database=MuseumDB;Trusted_Connection=True;");
        }
    }
}
