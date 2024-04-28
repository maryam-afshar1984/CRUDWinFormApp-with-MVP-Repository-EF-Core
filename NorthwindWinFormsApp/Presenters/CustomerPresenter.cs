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
            this._customerView.EditEvent += LoadSelectedCustomerToEdit;
            this._customerView.DeleteEvent += DeleteSelectedCustomer;
            this._customerView.SaveEvent += SaveCustomer;
            this._customerView.CancleEvent += CancleAction;

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

        private void AddNewCustomer(object? sender, EventArgs e)
        {
            _customerView.IsEdit = false;
        }

        private void LoadSelectedCustomerToEdit(object? sender, EventArgs e)
        {
            var customer = (Customer)_customerbindingSource.Current;
            _customerView.CustomerId =customer.CustomerId.ToString();
            _customerView.CompanyName = customer.CompanyName.ToString();
            _customerView.ContactName = customer.ContactName?.ToString();
            _customerView.ContactTitle = customer.ContactTitle?.ToString();
            _customerView.Address = customer.Address?.ToString();
            _customerView.City = customer.City?.ToString();
            _customerView.Region = customer.Region?.ToString();
            _customerView.PostalCode = customer.PostalCode?.ToString();
            _customerView.Country = customer.Country?.ToString();
            _customerView.Phone = customer.Phone?.ToString();
            _customerView.Fax = customer.Fax?.ToString();
            _customerView.IsEdit = true;
        }

        private void SaveCustomer(object? sender, EventArgs e)
        {
            var customerModel = new Customer();
            customerModel.CustomerId = _customerView.CustomerId.ToString();
            customerModel.CompanyName = _customerView.CompanyName.ToString();
            customerModel.ContactName = _customerView.ContactName.ToString();
            customerModel.ContactTitle = _customerView.ContactTitle.ToString();
            customerModel.Address = _customerView.Address.ToString();
            customerModel.City = _customerView.City.ToString();
            customerModel.Region = _customerView.Region.ToString();
            customerModel.PostalCode = _customerView.PostalCode.ToString();
            customerModel.Country = _customerView.Country.ToString();
            customerModel.Phone = _customerView.Phone.ToString();
            customerModel.Fax = _customerView.Fax.ToString();
            try
            {
                new Common.ModelDataValidation().Validate(customerModel);
                //Edit model
                if (_customerView.IsEdit)
                {
                    _customerRepository.Edit(customerModel);
                    _customerView.Message = "Customer edited successfully!";
                }
                //Add new model
                else
                {
                    _customerRepository.Add(customerModel);
                    _customerView.Message = "Customer added successfully!";
                }
                _customerView.IsSuccessful = true;
                LoadAllCustomerList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                _customerView.IsSuccessful = false;
                _customerView.Message = ex.Message;
            }

        }

        private void CleanViewFields()
        {
            _customerView.CustomerId = "";
            _customerView.CompanyName = "";
            _customerView.ContactName = "";
            _customerView.ContactTitle = "";
            _customerView.Address = "";
            _customerView.City = "";
            _customerView.Region = "";
            _customerView.PostalCode = "";
            _customerView.Country = "";
            _customerView.Phone = "";
            _customerView.Fax = "";
        }

        private void CancleAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void DeleteSelectedCustomer(object? sender, EventArgs e)
        {
            try
            {
                var customer = (Customer)_customerbindingSource.Current;
                _customerRepository.Delete(customer.CustomerId);
                _customerView.IsSuccessful = true;
                _customerView.Message = "Customer deleted successfully!";
                LoadAllCustomerList();  
            }
            catch (Exception ex)
            {
                _customerView.IsSuccessful = false;
                _customerView.Message = "An error ocurred, could not delete customer!";
                throw;
            }
        }
    }
}
