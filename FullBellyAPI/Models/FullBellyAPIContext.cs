using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FullBellyAPI.Models
{
    public class FullBellyAPIContext : DbContext
    {
        public FullBellyAPIContext(DbContextOptions<FullBellyAPIContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Donation>()
                .HasData(
                new Donation { DonationId = 1, Donor = "Seattle Tilth Alliance", DonationName = "Veggies", Address = "8445 55th Ave S", City = "Seattle", State = "WA", Zip = "98118", Date = DateTime.UtcNow, StartTime = "12:00", EndTime = "16:00", Lat = 47.5272298, Lng = -122.2640512, Description = "We have left over csa boxes for anyone who wants them.", Quantity = "10" },
                    new Donation { DonationId = 2, Donor = "Sacred Heart Seattle", DonationName = "Biscuits and Gravy", Address = "500 Wall St", City = "Seattle", State = "WA", Zip = "98121", Date = DateTime.UtcNow, StartTime = "9:00", EndTime = "20:00", Lat = 47.6178122, Lng = -122.3450959, Description = "This is our mobile soup kitchen van. We will operate until the cops crash the party", Quantity = "200" },
                    new Donation { DonationId = 3, Donor = "A Real Restaurant", DonationName = "Chicken dinner", Address = "2201 E Madison St", City = "Seattle", State = "WA", Zip = "98112", Date = DateTime.UtcNow, StartTime = "20:00", EndTime = "22:00", Lat = 47.6178326, Lng = -122.3033646, Description = "We are offering a sit down meal to anyone who cannot afford one. First come first serve. Continuation is based on your kind cooperation", Quantity = "20" },
                    new Donation { DonationId = 4, Donor = "Beacon Hill Elementary", DonationName = "Sandwiches", Address = "2025 14th Ave S", City = "Seattle", State = "WA", Zip = "98144", Date = DateTime.UtcNow, StartTime = "14:00", EndTime = "16:00", Lat = 47.5850714, Lng = -122.3153886, Description = "Our students are organizing a free sandwich day.", Quantity = "100" }
                );
        }
        public DbSet<Donation> Donations { get; set; }
    }
}