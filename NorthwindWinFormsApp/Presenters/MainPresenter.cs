using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using NorthwindWinFormsApp.Views;
using NorthwindWinFormsApp.Models;
using NorthwindWinFormsApp.Configuration;
using NorthwindWinFormsApp.Repositories;

namespace NorthwindWinFormsApp.Presenters
{
    public class MainPresenter
    {
        private IMainView _mainView;

        public MainPresenter(IMainView mainView)
        {
            _mainView = mainView;
            _mainView.ShowCustomerView += ShowCustomerView;
        }

        private void ShowCustomerView(object? sender, EventArgs e)
        {
            ICustomerView view = CustomerView.GetCustomerInstance((MainView)_mainView);
            ICustomerRepository repository = new CustomerRepository();
            new CustomerPresenter(view, repository);
        }
    }
}
