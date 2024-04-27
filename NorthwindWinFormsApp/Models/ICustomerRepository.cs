using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindWinFormsApp.Models
{
    public interface ICustomerRepository
    {
        void Add(Customer customer);
        void Edit(Customer customer);
        void Delete(string customerId);
        IEnumerable<Customer> GetAll();
        IEnumerable<Customer> GetByValue(string customerId);
    }
}
