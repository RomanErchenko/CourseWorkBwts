﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DataStorage
{
    public class ModelContext : DbContext
    {

        public ModelContext(DbContextOptions<ModelContext> options)
        : base(options)
        {



        }
        public DbSet<Alarm> Alarms { get; set; }
        public DbSet<Ams> Amses { get; set; }
        public DbSet<BwtsInsideOperatingValves> BwtsInsideOperatingValvess { get; set; }
        public DbSet<BwtsInsightTrottleValve> BwtsInsightTrottleValves { get; set; }
        public DbSet<DeascreatSignal> DeascreatSignals { get; set; }
        public DbSet<DigitalOutput> DigitalOutputs { get; set; }
        public DbSet<Gps> Gpss { get; set; }
        public DbSet<OperationLog> OperationLogs { get; set; }
        public DbSet<OutsideValvesConditionState> OutsideValvesConditionStates { get; set; }
        public DbSet<SensorValue> SensorValues { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           // modelBuilder.Entity<User>()
            //   .HasKey(u => u.Id);
           // modelBuilder.Entity<Notes>().HasOne(n => n.User).WithMany(u => u.Note).HasForeignKey(n => n.UserId);



            // Додаємо початкові дані до таблиці MyEntities
            // modelBuilder.Entity<User>().HasData(
            // new User { Id = new Guid("54f2f515-54a1-454a-9585-54a1454a9585"), Name = "Dimon", Login = "login", Password = "password" }
            // new User { Id = new Guid("54f2f515-54a2-454a-9585-54a1454a8756"), Name = "Pashka", Login = "login1", Password = "password1" }
            // );
            // modelBuilder.Entity<Notes>().HasData(
            // new Notes {Id= new Guid("dc3a0147-b894-48dd-80f4-420c4611a4c9"), Info = "Dimon Info1", Date = new DateTime(2023, 7, 20, 18, 30, 25), UserId = id1 },
            //new Notes {Id= new Guid("dc3a0147-b895-48dd-82f4-420c4611a4c9"), Info = "Pashka Info1", Date = new DateTime(2024, 7, 20, 18, 30, 25), UserId = new Guid("54f2f515-54a1-454a-9585-54a1454a9585") }
            // );
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder
            .UseLazyLoadingProxies()
            .UseSqlServer(@"Data Source=DESKTOP-F8JLP97;Initial Catalog=MemoryState;Integrated Security = true;TrustServerCertificate=True");

        }
    }

}

