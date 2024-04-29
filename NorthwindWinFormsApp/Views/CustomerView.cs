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

        //Cunstractor
        public CustomerView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            myTabControl.TabPages.Remove(tabPageCustomerDetales);
            btnExit.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            //Searche or read
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtCustomerID.KeyDown += (s, a) =>
            {
                if (a.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            //Add new or insert
            btnAdd.Click += delegate
            { 
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                myTabControl.TabPages.Remove(tabPageCustomerList);
                myTabControl.TabPages.Add(tabPageCustomerDetales);
                tabPageCustomerDetales.Text = "Add new customer";
            };
            //Edit or update
            btnUpdate.Click += delegate 
            { 
                EditEvent?.Invoke(this, EventArgs.Empty);
                myTabControl.TabPages.Remove(tabPageCustomerList);
                myTabControl.TabPages.Add(tabPageCustomerDetales);
                tabPageCustomerDetales.Text = "Edit customer";
            };
            //Delete
            btnDelete.Click += delegate 
            { 
                var result = MessageBox.Show("Are you sure you want to delete the selected customer?",
                    "Warning",MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                } 
            };
            //Save changes
            btnSave.Click += delegate 
            { 
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    myTabControl.TabPages.Remove(tabPageCustomerDetales);
                    myTabControl.TabPages.Add(tabPageCustomerList);
                }
                MessageBox.Show(Message);
            };
            //Cancel
            btnCancel.Click += delegate 
            { 
                CancleEvent?.Invoke(this, EventArgs.Empty);
                myTabControl.TabPages.Remove(tabPageCustomerDetales);
                myTabControl.TabPages.Add(tabPageCustomerList);
            };
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
            set { message = value; }
        }

        //Events
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancleEvent;

        private void CustomerDataGridView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            // Check if the row is not the header row and its index is odd
            if (e.RowIndex % 2 != 0 && e.RowIndex != CustomerDataGridView.RowCount - 1)
            {
                // Set the background color of the row
                CustomerDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
            }
            else
            {
                // Reset the background color of the row to the default color
                CustomerDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = CustomerDataGridView.DefaultCellStyle.BackColor;
            }
        }


        //Methods
        public void SetCustomerListBindingSource(BindingSource customerList)
        {
            if (CustomerDataGridView != null)
            {
                CustomerDataGridView.DataSource = customerList;
            }
        }

        //Singleton Pattern for opening only one form
        private static CustomerView customerInstance;
        public static CustomerView GetCustomerInstance(Form parentContainer)
        {
            if (customerInstance == null || customerInstance.IsDisposed)
            {
                customerInstance = new CustomerView();
                customerInstance.MdiParent = parentContainer;
                customerInstance.FormBorderStyle = FormBorderStyle.None;
                customerInstance.Dock = DockStyle.Fill;
            }
            else
            {
                if (customerInstance.WindowState == FormWindowState.Minimized)
                {
                    customerInstance.WindowState = FormWindowState.Normal;
                }
                customerInstance.BringToFront();
            }
            return customerInstance;
        }

    }
}
