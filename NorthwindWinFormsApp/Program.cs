using NorthwindWinFormsApp.Models;
using NorthwindWinFormsApp.Presenters;
using NorthwindWinFormsApp.Repositories;
using NorthwindWinFormsApp.Views;

namespace NorthwindWinFormsApp
{
    internal static class Program
    {
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