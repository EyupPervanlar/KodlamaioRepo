using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "A";
            customer1.LastName = "B";
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.GetList();
            customerManager.Delete();
            
        }
    }
}
