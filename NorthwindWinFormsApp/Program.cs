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
            ApplicationConfiguration.Initialize();
            Application.SetCompatibleTextRenderingDefault(false);

            IMainView view = new MainView();
            new MainPresenter(view);

            Application.Run((Form)view);

        }
    }
}