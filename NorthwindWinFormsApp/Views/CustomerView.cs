using NorthwindWinFormsApp.Models;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NorthwindWinFormsApp.Views
{
    public partial class CustomerView : Form, ICustomerView
    {
        //Fields
        private string message;
        private bool isSuccessful;
        private bool isEdit;
        //private string searchValue;
        //private string fax;
        //private string phone;
        //private string country;
        //private string postalCode;
        //private string region;
        //private string city;
        //private string address;
        //private string contactTitle;
        //private string contactName;
        //private string companyName;
        //private string customerId;
         
        //Cunstractor
        public CustomerView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            myTabControl.TabPages.Remove(tabPageCustomerDetales);
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtCustomerID.KeyDown += (s, a) =>
            {
                if (a.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            //other btn
        }

        //Properties
        public string CustomerId
        {
            get { return txtCustomerCode.Text; }
            set { txtCustomerCode.Text = value; }
        }
        public string CompanyName
        {
            get { return txtCompanyName.Text; }
            set { txtCompanyName.Text = value; }
        }
        public string ContactName
        {
            get { return txtContactName.Text; }
            set { txtContactName.Text = value; }
        }
        public string ContactTitle
        {
            get { return txtContactTitle.Text; }
            set { txtContactTitle.Text = value; }
        }
        public string Address
        {
            get { return txtAddress.Text; }
            set { txtAddress.Text = value; }
        }
        public string City
        {
            get { return txtCity.Text; }
            set { txtCity.Text = value; }
        }
        public string Region
        {
            get { return txtRegion.Text; }
            set { txtRegion.Text = value; }
        }
        public string PostalCode
        {
            get { return txtPostalCode.Text; }
            set { txtPostalCode.Text = value; }
        }
        public string Country 
        {
            get { return txtCountry.Text; }
            set { txtCountry.Text = value; }
        }
        public string Phone
        {
            get { return txtPhone.Text; }
            set { txtPhone.Text = value; }
        }
        public string Fax 
        {
            get { return txtFax.Text; }
            set { txtFax.Text = value; }
        }
        public string SearchValue 
        {
            get { return txtCustomerID.Text; }
            set { txtCustomerID.Text = value; }
        }
        public bool IsEdit 
        {
            get { return isEdit; }
            set { isEdit = value; }
        }
        public bool IsSuccessful 
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }
        public string Message 
        {
            get { return message; }
            set { Message = value; }
        }
        //string ICustomerView.CompanyName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //string ICustomerView.Region { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        //Events
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancleEvent;

        //Methods
        public void SetCustomerListBindingSource(BindingSource customerList)
        {
            if (CustomerDataGridView != null)
            {
                CustomerDataGridView.DataSource = customerList;
            }
        }

    }
}
