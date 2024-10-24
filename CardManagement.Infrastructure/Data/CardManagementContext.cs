using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardManagement.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace CardManagement.Infrastructure.Data
{
    public class CardManagementContext : DbContext
    {
        public CardManagementContext(DbContextOptions<CardManagementContext> options) : base(options)
        {
            
        }

        public DbSet<Customers> Customers { get; set; }
        public DbSet<Accounts> Accounts { get; set; }
        public DbSet<Transactions> Transactions { get; set; }


    }
}
