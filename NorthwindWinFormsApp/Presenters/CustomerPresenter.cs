using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindWinFormsApp.Views;
using NorthwindWinFormsApp.Models;
using NorthwindWinFormsApp.Configuration;

namespace NorthwindWinFormsApp.Presenters
{
    public class CustomerPresenter
    {
        //Fields
        private ICustomerView _customerView;
        private ICustomerRepository _customerRepository;
        private BindingSource _customerbindingSource;
        private IEnumerable<Customer> _customerList;

        // Cunstractor with Dependency injection
        public CustomerPresenter(ICustomerView customerView, ICustomerRepository customerRepository)
        {
            this._customerbindingSource = new BindingSource();
            _customerView = customerView;
            _customerRepository = customerRepository;

            //Sunscribe event handler methods to view events
            this._customerView.SearchEvent += SearchCustomer;
            this._customerView.AddNewEvent += AddNewCustomer;
            this._customerView.EditEvent += EditCustomer;
            this._customerView.DeleteEvent += DeleteCustomer;
            this._customerView.SaveEvent += SaveCustomer;
            this._customerView.CancleEvent += CancleCustomer;

            //Set Customer Binding Source
            this._customerView.SetCustomerListBindingSource(_customerbindingSource);
            //Load Customers List
            LoadAllCustomerList();
            //Show View
            this._customerView.Show();
        }

        //Methods
        private void LoadAllCustomerList()
        {
            _customerList= _customerRepository.GetAll();
            //Set data source
           _customerbindingSource.DataSource= _customerList;
        }

        private void SearchCustomer(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this._customerView.SearchValue);
            if(emptyValue==false)
            {
                _customerList = _customerRepository.GetByValue(this._customerView.SearchValue);
            }
            else
            {
                _customerList = this._customerRepository.GetAll();
            }
            _customerbindingSource.DataSource = _customerList;
        }

        private void CancleCustomer(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SaveCustomer(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteCustomer(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void EditCustomer(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewCustomer(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

    }
}
