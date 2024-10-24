using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardManagement.Domain.Entity
{
    public class Transactions 
    {
        public int Id { get; set; } 
        public double Amount { get; set; }
        public DateTime Date {  get; set; }
        public txnType TxnType { get; set; }
        public string Description { get; set; }
        public enum txnType
        {
            Deposit,
            Withdrawal,
            Transfer
        }
        public Accounts Account { get; set; }
        public int AccountID { get; set; }
    }
}
