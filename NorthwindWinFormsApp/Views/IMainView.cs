using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindWinFormsApp.Views
{
    public interface IMainView
    {
        event EventHandler ShowCustomerView;
        event EventHandler ShowInvoicesView;

    }
}
