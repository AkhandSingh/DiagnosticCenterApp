using AdcData.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace AdcData
{
    public class AdcDbContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; } = null!;
        public DbSet<Patient> Patients { get; set; } = null!;
        public DbSet<Diagnostic> Diagnoses { get; set; } = null!;

        private static string GetConnectionString()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            return configuration.GetConnectionString("AdcDB")
                   ?? throw new InvalidOperationException("Connection string 'AdcDB' not found.");
        }

        public AdcDbContext()
            : base(new DbContextOptionsBuilder<AdcDbContext>()
                .UseSqlServer(GetConnectionString())
                .Options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>();
            modelBuilder.Entity<Patient>();
            modelBuilder.Entity<Diagnostic>();
            base.OnModelCreating(modelBuilder);
        }
    }
}