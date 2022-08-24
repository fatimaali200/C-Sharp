using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        private List<Customer> customers = new List<Customer>();

        public void addCustomer(Customer customer)
        {
            Console.WriteLine("----------- Add Customer----------");
            customers.Add(customer);
            Console.WriteLine("Customer {0} has been Added Successful ;)",customer.NameSurname);

        }
        
        public void listCustomer()
        {
            Console.WriteLine("---------- List Customer -----------");
            foreach (Customer customer in customers)
            {
                Console.WriteLine("________________ {0} _________________",customer.ID);
                Console.WriteLine("Name Surname:" + customer.NameSurname);
                Console.WriteLine("Email:" + customer.Email);
                Console.WriteLine("Adress:" + customer.Adress);
            }
        }

        public void removCustomer(Customer customer)
        {
            Console.WriteLine("------ Remove Customer ----------");
            customers.Remove(customer);
            Console.WriteLine("Customer {0} has been Removed  Successful;)",customer.NameSurname);
        }
    }
}
