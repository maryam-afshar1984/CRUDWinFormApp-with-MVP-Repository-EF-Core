using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwindWinFormsApp.Views
{
    public partial class CustomersInvoicesView : Form, ICustomersInvoicesView
    {
        public CustomersInvoicesView()
        {
            InitializeComponent();
            btnExit.Click += delegate { this.Close(); };
        }

        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerContactName { get; set; }
        public string CustomerContactTitle { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerRegion { get; set; }
        public string CustomerPostalCode { get; set; }
        public string CustomerCountry { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerFax { get; set; }
        public string Salesperson { get; set; }
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public string ShipperName { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }
        public decimal ExtendedPrice { get; set ; }
        public decimal Freight { get; set; }
        string ICustomersInvoicesView.ProductName { get; set; }

        //Events
        private void CustomerInvoiceDataGridView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            // Check if the row is not the header row and its index is odd
            if (e.RowIndex % 2 != 0 && e.RowIndex != CustomerInvoiceDataGridView.RowCount - 1)
            {
                // Set the background color of the row
                CustomerInvoiceDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
            }
            else
            {
                // Reset the background color of the row to the default color
                CustomerInvoiceDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = CustomerInvoiceDataGridView.DefaultCellStyle.BackColor;
            }
        }
                //Methods
                public void SetCustomerInvoiceListBindingSource(BindingSource customerInvoiceList)
        {
            if (CustomerInvoiceDataGridView != null)
            {
                CustomerInvoiceDataGridView.DataSource = customerInvoiceList;
            }
        }

        //Singleton Pattern for opening only one form
        private static CustomersInvoicesView customerInvoicesInstance;
        public static CustomersInvoicesView GetCustomerInvoicesInstance(Form parentContainer)
        {
            if (customerInvoicesInstance == null || customerInvoicesInstance.IsDisposed)
            {
                customerInvoicesInstance = new CustomersInvoicesView();

                customerInvoicesInstance.MdiParent = parentContainer;
                customerInvoicesInstance.FormBorderStyle = FormBorderStyle.None;
                customerInvoicesInstance.Dock = DockStyle.Fill;
            }
            else
            {
                if (customerInvoicesInstance.WindowState == FormWindowState.Minimized)
                {
                    customerInvoicesInstance.WindowState = FormWindowState.Normal;
                }
                customerInvoicesInstance.BringToFront();
            }
            return customerInvoicesInstance;
        }
    }
}
