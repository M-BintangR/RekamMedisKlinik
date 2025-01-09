using RekamMedisKlinik.Session;

namespace RekamMedisKlinik
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

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Periksa apakah user sudah login
            if (UserSessions.CurrentUser != null)
            {
                // should be able to form menu if have user session
                Application.Run(new FormMenu());
            }
            else
            {
                // should be able to form login if not have user session
                Application.Run(new FormLogin());
            }
        }
    }
}