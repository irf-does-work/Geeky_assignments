using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardManagement.Domain.Entity
{
    public class Accounts
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public double Balance { get; set; }
        public Customers Customer { get; set; }
        public enum accountType
        {
            Debit,
            Credit
        }
        public accountType AccountType { get; set; }

        public int CustomerId { get; set; }
    }
}
