using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindWinFormsApp.Views
{
    public interface ICustomerView
    {
        //Properties- fields
        string CustomerId { get; set; }
        string CompanyName { get; set; }
        string ContactName { get; set; }
        string ContactTitle { get; set; }
        string Address { get; set; }
        string City { get; set; }
        string Region { get; set; }
        string PostalCode { get; set; }
        string Country { get; set; }
        string Phone { get; set; }
        string Fax { get; set; }


        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        //Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancleEvent;

        //Methods
        void SetCustomerListBindingSource(BindingSource customerList);
        void Show();
    }
}
