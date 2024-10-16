using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardManagementModels.Data;

namespace CardManagement.Models
{
    public class Transactions
    {
        [Key]

        public string TxnId { get; set; }
        public DateTime TransactionDate { get; set; }
        public enum TransactionType
        {
            Deposit,
            Withdrawal,
            Transfer
        }
        public double Amount { get; set; }
        public TransactionType transactionType { get; set; }
        public string Description;
        public Account Account { get; set; }

        public Transactions()
        {

        }
        public Transactions(int count, Account acc1, CardManagementContext context, double amount)
        {
            TxnId = "Txn" + (count + 1000).ToString();
            Amount = amount;
            Account = acc1;
            updateBalance(acc1, context);
        }

        public void updateBalance(Account acc2, CardManagementContext context2)
        {
            //CardManagementContext context2 = new CardManagementContext();
            var requiredAccount = context2.Account.FirstOrDefault(x => x.AccId == acc2.AccId);
            if (transactionType == TransactionType.Deposit)
            {
                Console.WriteLine("Balance: " + requiredAccount.Balance);
                requiredAccount.Balance = requiredAccount.Balance + Amount;
                Console.WriteLine("Updated Balance: " + requiredAccount.Balance);

            }

            else if (transactionType == TransactionType.Withdrawal || transactionType == TransactionType.Transfer)
            {
                Console.WriteLine("Balance: " + requiredAccount.Balance);
                requiredAccount.Balance = requiredAccount.Balance - Amount;
                Console.WriteLine("Updated Balance: " + requiredAccount.Balance);

            }
            context2.SaveChanges();
        }
    }
}
