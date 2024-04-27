using NorthwindWinFormsApp.Models;
using NorthwindWinFormsApp.Presenters;
using NorthwindWinFormsApp.Repositories;
using NorthwindWinFormsApp.Views;

namespace NorthwindWinFormsApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ICustomerView view = new CustomerView();
            ICustomerRepository repository = new CustomerRepository();
            new CustomerPresenter(view, repository);

            ApplicationConfiguration.Initialize();


            Application.Run((Form)view);
        }
    }
}