namespace StorageManager
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static bool validationFlag = false;
        [STAThread]
        static void Main()
        {

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            AuthorizationForm login = new AuthorizationForm();
            Application.Run(login);


            if (validationFlag)
            {
                MainFormAdmin mainForm= new MainFormAdmin();
                Application.Run(mainForm);
            }


            //Application.Run(new MainForm());
            
        }
    }
}