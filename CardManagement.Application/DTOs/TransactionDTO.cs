using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardManagement.Domain.Entity;

namespace CardManagement.Application.DTOs
{
    public class TransactionDTO
    {
        public int Id { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public CardManagement.Domain.Entity.Transactions.txnType TxnType { get; set; }
        public string Description { get; set; }
        //public Accounts Account { get; set; }
        public int AccountID { get; set; }
    }
}
