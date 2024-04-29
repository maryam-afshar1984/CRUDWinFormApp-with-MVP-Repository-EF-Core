using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using NorthwindWinFormsApp.Views;
using NorthwindWinFormsApp.Configuration;
using NorthwindWinFormsApp.Repositories;

namespace NorthwindWinFormsApp.Presenters
{
    public class MainPresenter
    {
        private IMainView mainView;

        public MainPresenter(IMainView mainView)
        {
            this.mainView = mainView;
            this.mainView.ShowCustomerView += ShowCustomerView;
            this.mainView.ShowInvoicesCustomerView += ShowInvoicesCustomerView;
        }

        private void ShowCustomerView(object? sender, EventArgs e)
        {
            ICustomerView view = CustomerView.GetCustomerInstance((MainView)this.mainView);
            ICustomerRepository repository = new CustomerRepository();
            new CustomerPresenter(view, repository);
        }

        private void ShowInvoicesCustomerView(object? sender, EventArgs e)
        {
            ICustomersInvoicesView view = CustomersInvoicesView.GetCustomerInvoicesInstance((MainView)this.mainView);
            ICustomersInvoicesRepository repository = new CustomersInvoicesReposotory();
            new CustomersInvoicesPresenter(view, repository);
        }
    }
}
