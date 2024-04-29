using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindWinFormsApp.Models
{
    public class CombinedInvoicesAndCustomers
    {

        public string? ShipName { get; set; }

        public string? ShipAddress { get; set; }

        public string? ShipCity { get; set; }

        public string? ShipRegion { get; set; }

        public string? ShipPostalCode { get; set; }

        public string? ShipCountry { get; set; }

        public string? CustomerId { get; set; }

        public string CustomerName { get; set; } = null!;

        public string? CustomerContactName { get; set; } 

        public string? CustomerContactTitle { get; set; }

        public string? CustomerAddress { get; set; }

        public string? CustomerCity { get; set; }

        public string? CustomerRegion { get; set; }

        public string? CustomerPostalCode { get; set; }

        public string? CustomerCountry { get; set; }
        
        public string? CustomerPhone { get; set; }

        public string? CustomerFax { get; set; }

        public string Salesperson { get; set; } = null!;

        public int OrderId { get; set; }

        public DateTime? OrderDate { get; set; }

        public DateTime? RequiredDate { get; set; }

        public DateTime? ShippedDate { get; set; }

        public string ShipperName { get; set; } = null!;

        public int ProductId { get; set; }

        public string ProductName { get; set; } = null!;

        public decimal UnitPrice { get; set; }

        public short Quantity { get; set; }

        public float Discount { get; set; }

        public decimal? ExtendedPrice { get; set; }

        public decimal? Freight { get; set; }
    }
}
