using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using ClinicBookingg.Models;

namespace ClinicBookingg.Data
{
    public class ClinicContext : DbContext
    {
        public ClinicContext(DbContextOptions<ClinicContext> options) : base(options) { }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // 1. Doctors Seed Data
            modelBuilder.Entity<Doctor>().HasData(
                new Doctor { Id = 1, Name = "Dr. Amina Farid", Specialty = "Cardiology", YearsOfExperience = 15, Bio = "Expert cardiologist.", Phone = "01012345678", LicenceNumber = "LIC-1001", ImageUrl = "doc1.jpg" },
                new Doctor { Id = 2, Name = "Dr. Youssef Hany", Specialty = "Dermatology", YearsOfExperience = 8, Bio = "Cosmetic & medical dermatology.", Phone = "01123456789", LicenceNumber = "LIC-1002", ImageUrl = "doc2.jpg" },
                new Doctor { Id = 3, Name = "Dr. Layla Mahmoud", Specialty = "Pediatrics", YearsOfExperience = 12, Bio = "Pediatrician caring for children.", Phone = "01234567890", LicenceNumber = "LIC-1003", ImageUrl = "doc3.jpg" },
                new Doctor { Id = 4, Name = "Dr. Omar Nasser", Specialty = "Orthopedics", YearsOfExperience = 20, Bio = "Senior orthopedic surgeon.", Phone = "01545678901", LicenceNumber = "LIC-1004", ImageUrl = "doc4.jpg" },
                new Doctor { Id = 5, Name = "Dr. Salma Ibrahim", Specialty = "Dentistry", YearsOfExperience = 6, Bio = "General and cosmetic dentistry.", Phone = "01098765432", LicenceNumber = "LIC-1005", ImageUrl = "doc5.jpg" }
            );

            // 2. Q1: Password Hashing & Users Seed Data
            var hasher = new PasswordHasher<User>();

            var admin = new User { Id = 1, Email = "admin@clinic.com", Role = "Admin" };
            admin.PasswordHash = hasher.HashPassword(admin, "Admin123!");

            var rec1 = new User { Id = 2, Email = "rec1@clinic.com", Role = "Receptionist" };
            rec1.PasswordHash = hasher.HashPassword(rec1, "Rec12345!");

            var rec2 = new User { Id = 3, Email = "rec2@clinic.com", Role = "Receptionist" };
            rec2.PasswordHash = hasher.HashPassword(rec2, "Rec12345!");

            modelBuilder.Entity<User>().HasData(admin, rec1, rec2);
        }
    }
}