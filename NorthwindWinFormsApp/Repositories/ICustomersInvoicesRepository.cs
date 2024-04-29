using NorthwindWinFormsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindWinFormsApp.Repositories
{
    public interface ICustomersInvoicesRepository : IRepository<CombinedInvoicesAndCustomers>
    {
        void Add(CombinedInvoicesAndCustomers customerInvoices);
        void Edit(CombinedInvoicesAndCustomers customerInvoices);
        void Delete(string customerId);
        IEnumerable<CombinedInvoicesAndCustomers> GetAll();
        IEnumerable<CombinedInvoicesAndCustomers> GetByValue(string customerId);
    }
}
