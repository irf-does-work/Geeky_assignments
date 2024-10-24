using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardManagement.Domain.Entity;
using CardManagement.Infrastructure.Data;
using CardManagement.Infrastructure.Repositories;

namespace CardManagement.Infrastructure.Repository.Implementation
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CardManagementContext _context;

        public CustomerRepository(CardManagementContext context)
        {
            _context = context;
        }

        public int Add(Customers cust)
        {
            _context.Customers.Add(cust);
            return _context.SaveChanges();
        }
    }
}
