using NorthwindWinFormsApp.Models;
using NorthwindWinFormsApp.Repositories;
using NorthwindWinFormsApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindWinFormsApp.Presenters
{
    public class CustomersInvoicesPresenter
    {
        //Fields
        private ICustomersInvoicesView customerInvoicesView;
        private ICustomersInvoicesRepository customersInvoicesReposotory;
        private BindingSource customerInvoicesSource;
        private IEnumerable<CombinedInvoicesAndCustomers> customerInvoicesList;

        // Cunstractor with Dependency injection
        public CustomersInvoicesPresenter(ICustomersInvoicesView customerInvoicesView, ICustomersInvoicesRepository customersInvoicesReposotory)
        {
            this.customerInvoicesView = customerInvoicesView;
            this.customersInvoicesReposotory = customersInvoicesReposotory;
            this.customerInvoicesSource = new BindingSource();

            //Set Customer Binding Source
            this.customerInvoicesView.SetCustomerInvoiceListBindingSource(customerInvoicesSource);

            //Load Customers List
            LoadAllCustomerInvoicesList();

            //Show View
            this.customerInvoicesView.Show();
        }

        //Methods
        private void LoadAllCustomerInvoicesList()
        {
            customerInvoicesList = customersInvoicesReposotory.GetAll();
            //Set data source
            customerInvoicesSource.DataSource = customerInvoicesList;
        }
    }
}
