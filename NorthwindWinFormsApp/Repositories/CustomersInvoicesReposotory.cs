using NorthwindWinFormsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindWinFormsApp.Models;

namespace NorthwindWinFormsApp.Repositories
{
    public class CustomersInvoicesReposotory : ICustomersInvoicesRepository
    {
        public void Add(CombinedInvoicesAndCustomers customerInvoices)
        {
            throw new NotImplementedException();
        }

        public void Delete(string customerId)
        {
            throw new NotImplementedException();
        }

        public void Edit(CombinedInvoicesAndCustomers customerInvoices)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CombinedInvoicesAndCustomers> GetAll()
        {
            var customerInvoicesList = new List<CombinedInvoicesAndCustomers>();
            using (var context = new NorthwindContext())
            {
                customerInvoicesList = context.CombinedInvoicesAndCustomers.ToList(); ;
            }
            return customerInvoicesList;
        }

        public IEnumerable<CombinedInvoicesAndCustomers> GetByValue(string customerId)
        {
            throw new NotImplementedException();
        }
    }
}
