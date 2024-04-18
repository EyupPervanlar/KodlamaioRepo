using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    public interface ICostumerDal
    {
        void Add(Customer customer);
        void Update();
        void Delete();
        List<Customer>GetList();
    }
}
