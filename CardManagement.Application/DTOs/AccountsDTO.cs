using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardManagement.Domain.Entity;

namespace CardManagement.Application.DTOs
{
    public class AccountsDTO
    {
        public string Number { get; set; }
        public double Balance { get; set; }
        public CardManagement.Domain.Entity.Accounts.accountType AccountType { get; set; }
        public int CustomerId { get; set; }
    }
}
