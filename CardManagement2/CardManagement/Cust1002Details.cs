using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using CardManagement.Models;
using CardManagementModels.Data;


//Write a method to display the details of Customer with Id =2, fetch details from db

namespace CardManagement
{
    public class Cust1002Details
    {
        Customer customer1;
        
        public void Display()
        {
            Console.WriteLine("Details of Cust1002: ");
            Console.WriteLine("Name: " +customer1.CustomerName);
            Console.WriteLine("Email: " + customer1.Email);
            Console.WriteLine("Phone No: "+ customer1.PhoneNumber);
            Console.WriteLine("Address: " + customer1.CustomerAddress);

        }
        public Cust1002Details(CardManagementContext c1)
        {
            //using CardManagementContext context = new CardManagementContext();
            customer1 = c1.Customer.FirstOrDefault(x => x.CustId == "Cust1002");
            if (customer1 == null)
            {
                Console.WriteLine("Customer with given ID does not exist");
                return;
            }
            this.Display();
           
        }
    }


    
}
