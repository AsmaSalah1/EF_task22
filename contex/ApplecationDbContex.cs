using EF_Task22.configration;
using EF_Task22.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Task22.contex
{
    internal class ApplecationDbContex:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //connection string
            optionsBuilder.UseSqlServer("Server=DESKTOP-43Q1A7I\\MSSQLSERVER01;Database=EF_Task22;Trusted_Connection=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration( new ProductConfigration());
            modelBuilder.ApplyConfiguration(new OrderConfigration());

        }
        public DbSet<product> products { get; set; }
        public DbSet<Order> orders { get; set; }

    }
}
