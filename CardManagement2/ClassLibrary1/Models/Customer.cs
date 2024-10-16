using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardManagement.Models
{
    public class Customer
    {
        [Key]
        public string CustId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string Email {  get; set; } 
        public string PhoneNumber { get; set; }

        public List<Account> Accounts {  get; set; }

        public Customer()
        {
            
        }
        public Customer(int count)
        {
            CustId = "Cust" + (count + 1000).ToString();
        }
    }

}
