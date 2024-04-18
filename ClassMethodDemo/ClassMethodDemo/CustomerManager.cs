using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    public class CustomerManager : ICostumerDal
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer İs added");
        }

        public void Delete()
        {
            Console.WriteLine("Customer İs deleted");
        }

        public List<Customer> GetList()
        {
            Console.WriteLine("Customer İs listed");
            return new List<Customer>();
        }

        public void Update()
        {
            Console.WriteLine("Customer İs updeted");
        }
    }
}
