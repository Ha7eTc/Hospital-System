using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System_Lab_2
{
    public class PersonalContext: DbContext
    {
       public DbSet<Doctor> Doctors { get; set; }
       public DbSet<Nurse> Nurses { get; set; }
       public DbSet<Person> Persons { get; set; }

        public PersonalContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=hospital.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // TPH — одна таблиця Persons з колонкою-дискримінатором
            modelBuilder.Entity<Person>()
                .HasDiscriminator<string>("PersonType")
                .HasValue<Person>("Person")
                .HasValue<Doctor>("Doctor")
                .HasValue<Nurse>("Nurse");

            modelBuilder.Entity<Person>().ToTable("Persons");

            modelBuilder.Entity<Doctor>()
                .Property(d => d.Specialization)
                .HasMaxLength(100);

            modelBuilder.Entity<Nurse>()
                .Property(n => n.Departament)
                .HasMaxLength(100);
        }

    }
}
