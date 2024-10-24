using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardManagement.Domain.Entity;
using CardManagement.Infrastructure.Data;

namespace CardManagement.Infrastructure.Repositories
{
    public interface ICustomerRepository
    {
        public int Add(Customers cust);
        
    }
}
