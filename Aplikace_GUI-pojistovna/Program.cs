
namespace Aplikace_GUI_pojistovna
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

            dbTest();

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            
        }

        private static void dbTest() {
            DatabaseConnection databaseConnection = new DatabaseConnection();
            bool isConnected = databaseConnection.TestConnectionAsync().GetAwaiter().GetResult();

            if (isConnected)
            {
                MessageBox.Show("Database connection successful!", "Connection Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Database connection failed.", "Connection Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }






    }
}