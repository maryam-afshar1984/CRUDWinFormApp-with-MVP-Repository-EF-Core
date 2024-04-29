using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindWinFormsApp.Views
{
    public interface ICustomersInvoicesView
    {
        //Properties- fields
         string ShipName { get; set; }
         string ShipAddress { get; set; }
         string ShipCity { get; set; }
         string ShipRegion { get; set; }
         string ShipPostalCode { get; set; }
         string ShipCountry { get; set; }
         string CustomerId { get; set; }
         string CustomerName { get; set; } 
         string CustomerContactName { get; set; }
         string CustomerContactTitle { get; set; }
         string CustomerAddress { get; set; }
         string CustomerCity { get; set; }
         string CustomerRegion { get; set; }
         string CustomerPostalCode { get; set; }
         string CustomerCountry { get; set; }
         string CustomerPhone { get; set; }
         string CustomerFax { get; set; }
         string Salesperson { get; set; } 
         int OrderId { get; set; }
         DateTime OrderDate { get; set; }
         DateTime RequiredDate { get; set; }
         DateTime ShippedDate { get; set; }
         string ShipperName { get; set; } 
         int ProductId { get; set; }
         string ProductName { get; set; } 
         decimal UnitPrice { get; set; }
         short Quantity { get; set; }
         float Discount { get; set; }
         decimal ExtendedPrice { get; set; }
         decimal Freight { get; set; }


        //Methods
        void SetCustomerInvoiceListBindingSource(BindingSource customerInvoiceList);
        void Show();
    }
}
