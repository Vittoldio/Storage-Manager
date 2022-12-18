using StorageManager.Forms;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.CompilerServices;

namespace StorageManager
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static bool validationFlag = false;
        static bool adminFlag = true;
        public static string login;
        [STAThread]
       
        public static void Main()
        {

            Application.EnableVisualStyles();
            ApplicationConfiguration.Initialize();
            AuthorizationForm login = new AuthorizationForm();
            Application.Run(login);
            
            if (validationFlag && adminFlag)
            {
                MainForm mainForm = new MainForm();
                Application.Run(mainForm);
            }
        }
    }
}