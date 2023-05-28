using Біржа_товарів.Forms;
using Біржа_товарів.Models;

namespace Біржа_товарів
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
            Application.Run(new AuthorizationForm());

        }
    }
}