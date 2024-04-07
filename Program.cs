using MyProject.Froms;
using MyProject.Models.Data;

namespace MyProject
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
            var _context = new MyDatabaseContext();
            Application.Run(new MainFrm(_context));
        }
    }
}