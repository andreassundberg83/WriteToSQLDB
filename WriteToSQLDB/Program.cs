namespace WriteToSQLDB
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!File.Exists($"{Directory.GetCurrentDirectory()}\\sqldirectory.txt"))
            {
                File.WriteAllText($"{Directory.GetCurrentDirectory()}\\sqldirectory.txt", @"C:\\Program Files\\Microsoft SQL Server\\");
            }
            ApplicationConfiguration.Initialize();
            
            Application.Run(new Form1());
        }
    }
}