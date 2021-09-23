using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ParttyPlotSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParttyPlotSystem.Data
{

    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Plot> Plots { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ParttyPlotSystem.Models.Plot> Plot { get; set; }

    }
}
