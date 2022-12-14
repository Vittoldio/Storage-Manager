namespace StorageManager
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static bool validationFlag = false;
        public static bool adminFlag = false;
        public static string UserName;
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            AuthorizationForm login = new AuthorizationForm();
            Application.Run(login);
            if (validationFlag && adminFlag)
            {
                MainFormAdmin mainForm = new MainFormAdmin();
                Application.Run(mainForm);
            }
            else if (validationFlag)
            {
                MainFormUser mainForm = new MainFormUser();
                Application.Run(mainForm);
            }



            //Application.Run(new MainForm());
            
        }
    }
}