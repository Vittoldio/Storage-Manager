using StorageManager.Forms;
namespace StorageManager
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());            
        }
    }
}