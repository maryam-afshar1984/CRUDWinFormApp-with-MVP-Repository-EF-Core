using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindWinFormsApp.Models;

namespace NorthwindWinFormsApp.Repositories
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        void Add(Customer customer);
        void Edit(Customer customer);
        void Delete(string customerId);
        IEnumerable<Customer> GetAll();
        IEnumerable<Customer> GetByValue(string customerId);
    }
}
