using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardManagement.Domain.Entity;

namespace CardManagement.Application.DTOs
{
    public class CustomerDTO
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public List<AccountsDTO> Accounts { get; set; }
    }
}
