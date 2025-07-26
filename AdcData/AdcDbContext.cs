using AdcData.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace AdcData
{
    public class AdcDbContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; } = null!;
        public DbSet<Patient> Patients { get; set; } = null!;
        public DbSet<Diagnostic> Diagnoses { get; set; } = null!;

        public AdcDbContext()
            : base(new DbContextOptionsBuilder<AdcDbContext>()
                .UseSqlServer("Data Source=DESKTOP-D68JPH2;Initial Catalog=ADC;Integrated Security=True;TrustServerCertificate=True;")
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