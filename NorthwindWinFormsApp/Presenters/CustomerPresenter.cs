using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindWinFormsApp.Views;
using NorthwindWinFormsApp.Models;
using NorthwindWinFormsApp.Configuration;
using NorthwindWinFormsApp.Repositories;

namespace NorthwindWinFormsApp.Presenters
{
    public class CustomerPresenter
    {
        //Fields
        private ICustomerView customerView;
        private ICustomerRepository customerRepository;
        private BindingSource customerbindingSource;
        private IEnumerable<Customer> customerList;

        // Cunstractor with Dependency injection
        public CustomerPresenter(ICustomerView customerView, ICustomerRepository customerRepository)
        {
            this.customerbindingSource = new BindingSource();
            this.customerView = customerView;
            this.customerRepository = customerRepository;

            //Sunscribe event handler methods to view events
            this.customerView.SearchEvent += SearchCustomer;
            this.customerView.AddNewEvent += AddNewCustomer;
            this.customerView.EditEvent += LoadSelectedCustomerToEdit;
            this.customerView.DeleteEvent += DeleteSelectedCustomer;
            this.customerView.SaveEvent += SaveCustomer;
            this.customerView.CancleEvent += CancleAction;

            //Set Customer Binding Source
            this.customerView.SetCustomerListBindingSource(customerbindingSource);

            //Load Customers List
            LoadAllCustomerList();

            //Show View
            this.customerView.Show();
        }


        //Methods
        private void LoadAllCustomerList()
        {
            customerList= customerRepository.GetAll();
            //Set data source
           customerbindingSource.DataSource= customerList;
        }

        private void SearchCustomer(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.customerView.SearchValue);
            if(emptyValue==false)
            {
                customerList = customerRepository.GetByValue(this.customerView.SearchValue);
            }
            else
            {
                customerList = this.customerRepository.GetAll();
            }
            customerbindingSource.DataSource = customerList;
        }     

        private void AddNewCustomer(object? sender, EventArgs e)
        {
            customerView.IsEdit = false;
        }

        private void LoadSelectedCustomerToEdit(object? sender, EventArgs e)
        {
            var customer = (Customer)customerbindingSource.Current;
            customerView.CustomerId =customer.CustomerId.ToString();
            customerView.CompanyName = customer.CompanyName.ToString();
            customerView.ContactName = customer.ContactName?.ToString();
            customerView.ContactTitle = customer.ContactTitle?.ToString();
            customerView.Address = customer.Address?.ToString();
            customerView.City = customer.City?.ToString();
            customerView.Region = customer.Region?.ToString();
            customerView.PostalCode = customer.PostalCode?.ToString();
            customerView.Country = customer.Country?.ToString();
            customerView.Phone = customer.Phone?.ToString();
            customerView.Fax = customer.Fax?.ToString();
            customerView.IsEdit = true;
        }

        private void SaveCustomer(object? sender, EventArgs e)
        {
            var customerModel = new Customer();
            customerModel.CustomerId = customerView.CustomerId.ToString();
            customerModel.CompanyName = customerView.CompanyName.ToString();
            customerModel.ContactName = customerView.ContactName.ToString();
            customerModel.ContactTitle = customerView.ContactTitle.ToString();
            customerModel.Address = customerView.Address.ToString();
            customerModel.City = customerView.City.ToString();
            customerModel.Region = customerView.Region.ToString();
            customerModel.PostalCode = customerView.PostalCode.ToString();
            customerModel.Country = customerView.Country.ToString();
            customerModel.Phone = customerView.Phone.ToString();
            customerModel.Fax = customerView.Fax.ToString();
            try
            {
                //Chech data validation
                new Common.ModelDataValidation().Validate(customerModel);

                //Edit model
                if (customerView.IsEdit)
                {
                    customerRepository.Edit(customerModel);
                    customerView.Message = "Customer edited successfully!";
                }
                //Add new model
                else
                {
                    customerRepository.Add(customerModel);
                    customerView.Message = "Customer added successfully!";
                }
                customerView.IsSuccessful = true;
                LoadAllCustomerList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                customerView.IsSuccessful = false;
                customerView.Message = ex.Message;
            }

        }

        private void CleanViewFields()
        {
            customerView.CustomerId = "";
            customerView.CompanyName = "";
            customerView.ContactName = "";
            customerView.ContactTitle = "";
            customerView.Address = "";
            customerView.City = "";
            customerView.Region = "";
            customerView.PostalCode = "";
            customerView.Country = "";
            customerView.Phone = "";
            customerView.Fax = "";
        }

        private void CancleAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void DeleteSelectedCustomer(object? sender, EventArgs e)
        {
            try
            {
                var customer = (Customer)customerbindingSource.Current;
                customerRepository.Delete(customer.CustomerId);
                customerView.IsSuccessful = true;
                customerView.Message = "Customer deleted successfully!";
                LoadAllCustomerList();  
            }
            catch (Exception ex)
            {
                customerView.IsSuccessful = false;
                customerView.Message = "An error ocurred, could not delete customer!";
                throw;
            }
        }
    }
}
