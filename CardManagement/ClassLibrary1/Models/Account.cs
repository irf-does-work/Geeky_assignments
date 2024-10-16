using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardManagement.Models
{
    public class Account
    {
        [Key]
        public string AccId { get; set; }
        public string AccountNumber { get; set; }
        public AccountType accountType { get; set; }
        public enum AccountType
        {
            Debit,
            Credit
        } 

        public double Balance { get; set; }

        public Account()
        {
            
        }
        public Account(int count)
        {
            AccId = "Acc" + (count + 1000).ToString();
        }
    }
    
}
