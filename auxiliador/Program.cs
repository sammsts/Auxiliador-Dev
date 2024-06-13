namespace auxiliador
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
            ApplicationConfiguration.Initialize();
#if !DEBUG
            Application.Run(new frmLogin());
#else
            Application.Run(new frmHome());
#endif
        }
    }
}