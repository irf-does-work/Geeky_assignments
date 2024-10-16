using System.ComponentModel;
using CardManagement;
using CardManagement.Models;
using CardManagementModels.Data;
using Microsoft.EntityFrameworkCore;

using CardManagementContext context1 = new CardManagementContext();

int customerCount = context1.Customer.Count() + 1;
int accountCount = context1.Account.Count() + 1;
int txncount = context1.Transactions.Count() + 1;

Console.WriteLine(customerCount);
Console.WriteLine(accountCount);
Console.WriteLine(txncount);

//List the Customer Details
foreach (var customer in context1.Customer)
{
    Console.WriteLine("Customer Id: " + customer.CustId);
    Console.WriteLine("Name: " + customer.CustomerName);
    Console.WriteLine("Address: " + customer.CustomerAddress);
    Console.WriteLine("Email: " + customer.Email);
    Console.WriteLine("Phone No: " + customer.PhoneNumber);
}

//List Accounts of a customer
Console.WriteLine("Enter a Customer ID: ");
string inputCustId = Console.ReadLine();
var custQ2 = context1.Customer.FirstOrDefault(x => x.CustId == inputCustId);
Console.WriteLine("ACCOUNT  DETAILS:");
if (custQ2 != null)
{
    foreach (var acc in custQ2.Accounts)
    {
        Console.WriteLine(acc.AccId);
        Console.WriteLine(acc.AccountNumber);
        Console.WriteLine(acc.Balance);
        Console.WriteLine(acc.accountType);
    }
}
else
{
    Console.WriteLine("Customer with CustId 'Cust1003' not found.");
}


//List the Transactions of an Account
Console.WriteLine("Enter an Account ID: ");
string inputAccId = Console.ReadLine();
var transactions = context1.Transactions.Where(x => x.Account.AccId == inputAccId);
Console.WriteLine("Transactions associated with " +inputAccId + ":");
foreach (var txn in transactions)
{
    Console.WriteLine(txn.TxnId);
}


//Create logic to update the balance when adding a transaction by its type
var transactedAccount = context1.Account.FirstOrDefault(x => x.AccId == "Acc1002");
double amount = 1000;

Transactions transaction1 = new Transactions(txncount,transactedAccount,context1,amount)
{
    TransactionDate = DateTime.Now,
    transactionType = Transactions.TransactionType.Deposit
    

};
context1.Transactions.Add(transaction1);
context1.SaveChanges();

//Add Customer to db
Customer customer1 = new Customer(customerCount)
{
    CustomerName = "Charlie",
    PhoneNumber = "9988776655",
    Email = "charlie@hotmail.com",
    CustomerAddress = "Veli",
};
context1.Customer.Add(customer1);


//Add Account to Db
Account account1 = new Account(accountCount)
{
    AccountNumber = "100200300",
    accountType = Account.AccountType.Debit,
    Balance = 20000,
};
var accList = new List<Account>();
customer1.Accounts=accList;
context1.Account.Add(account1);

//Write a method to display the details of Customer with Id =2, fetch details from db
Cust1002Details cust1002 = new Cust1002Details(context1);



//Transactions transaction1 =new Transactions(txncount)
//{
//   Amount = 100,
//   TransactionDate = DateTime.Now,
//   Account = context1.Account.FirstOrDefault(x=> x.AccId == "Acc1002"),
//   transactionType = Transactions.TransactionType.Deposit

//};

//context1.Transactions.Add(transaction1);
//context1.SaveChanges();

//var custQ2 = context1.Customer
//                     .Include(c => c.Accounts) // Eagerly load Accounts
//                     .FirstOrDefault(x => x.CustId == "Cust1003");

////var custQ2 = context1.Customer.FirstOrDefault(x => x.CustId == "Cust1003");
//Console.WriteLine("ACCOUNT  DETAILS:"); 
//if (custQ2 != null)
//{
//   foreach (var acc in custQ2.Accounts)
//    {
//        Console.WriteLine(acc.AccId);
//        Console.WriteLine(acc.AccountNumber);
//        Console.WriteLine(acc.Balance);
//        Console.WriteLine(acc.accountType);
//    }
//}
//else
//{
//    Console.WriteLine("Customer with CustId 'Cust1003' not found.");
//}

//Console.WriteLine("Enter the Id of the customer: ");




//string requiredCustId = Console.ReadLine();
//var requiredCust = context1.Customer.FirstOrDefault(x => x.CustId == requiredCustId);

//foreach (var item in context1.Customer)
//{
//    Console.WriteLine(item.CustId);
//    Console.WriteLine(item.CustomerName);
//    Console.WriteLine(item.PhoneNumber);
//    Console.WriteLine(item.CustomerAddress);

//}



//if (requiredCust != null)
//{
//    Console.WriteLine(requiredCust.CustId);
//    Console.WriteLine(requiredCust.CustomerName);
//    Console.WriteLine(requiredCust.PhoneNumber);
//    Console.WriteLine(requiredCust.CustomerAddress);
//}

//var cust2 = context1.Customer.FirstOrDefault(x => x.CustId == "Cust1002");
////var cust5 = context1.Customer.FirstOrDefault(x => x.CustId == "Cust1005");
//Console.WriteLine("c2 details:");
//if (cust2 != null)
//{
//    Console.WriteLine(cust2.CustId);
//    Console.WriteLine(cust2.CustomerName);
//    Console.WriteLine(cust2.PhoneNumber);
//    Console.WriteLine(cust2.CustomerAddress);
//}
//Console.WriteLine("Accounts:");
//var acc2 = cust2.Accounts;
//foreach (var accouints in acc2)
//{
//    Console.WriteLine(accouints.AccId);
//    Console.WriteLine(accouints.AccountNumber);
//    Console.WriteLine(accouints.Balance);
//    Console.WriteLine(accouints.accountType);

//}



//Customer customer1 = new Customer(customerCount)
//{
//    CustomerName = "Charlie",
//    PhoneNumber = "9988776655",
//    Email = "charlie@hotmail.com",
//    CustomerAddress = "Veli",
//};

//Account account1 = new Account(accountCount)

//{
//    AccountNumber = "100200300",
//    accountType = Account.AccountType.Debit,
//    Balance = 20000,

//};

//var accList = new List<Account>();
//accList.Add(account1);

//context1.Customer.Add(customer1);
//context1.Account.Add(account1);


//customer1.Accounts=accList;
//context1.SaveChanges();



//context1.Customer.Add(customer1);
//context1.SaveChanges();
//var custAccount = context1.Customer.First(x => x.CustId == "Cust1001");

//if (customer1.Accounts == null)
//{
//    customer1.Accounts = new List<Account>();
//    Console.WriteLine("accountlist was nul so initialized");
//}
//Account account1 = new Account(accountCount)

//{
//    AccountNumber = "100200300",
//    accountType = Account.AccountType.Debit,
//    Balance = 10000,

//};






















//var accountToRemove = context1.Account.FirstOrDefault(x => x.AccId == "Acc1002");
//context1.Account.Remove(accountToRemove);
//context1.SaveChanges();

////Customer cust1 = new Customer()
////{
////    CustomerName = "John",
////    PhoneNumber = "1234567890",
////    Email = "John@gmail.com",
////    CustomerAddress = "Trivandrum",
////    Accounts = new List<Account>()
////};

//Account account1 = new Account()
//{
//    AccountNumber = "91011",
//    accountType = Account.AccountType.Credit,
//    Balance = 10000,
//};

//Account account2 = new Account()
//{
//    AccountNumber = "121314",
//    accountType = Account.AccountType.Debit,
//    Balance = 5000,
//};

//context1.Account.Add(account1);
////context1.Customer.Add(cust1);
////cust1.Accounts.Add(account1);
//context1.Account.Add(account2);
////cust1.Accounts.Add(account2);
//context1.SaveChanges();