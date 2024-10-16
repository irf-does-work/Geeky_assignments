using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace CardManagementModels.Data
{
    public class CardManagementContext : DbContext 
    {
        public DbSet<Account> Account { get; set; }
        public DbSet<Transactions> Transactions { get; set; }
        public DbSet<Customer> Customer { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=localhost,1430;Database=CardManagement;User Id=sa;Password=Pass@w0rd;TrustServerCertificate=true");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(a => a.accountType)
                .HasConversion<string>(); // Converts the enum to its string representation

            base.OnModelCreating(modelBuilder);
        }

    }
}
