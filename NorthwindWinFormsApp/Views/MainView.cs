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
    public partial class MainView : Form,IMainView
    {
        public MainView()
        {
            InitializeComponent();
            btnCustomerView.Click += delegate { ShowCustomerView?.Invoke(this, EventArgs.Empty); };
        }

        public event EventHandler ShowCustomerView;
        public event EventHandler ShowInvoicesView;

       
    }
}
