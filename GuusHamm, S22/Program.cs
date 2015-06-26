namespace GuusHamm__S22
{
    #region

    using System;
    using System.Windows.Forms;

    #endregion

    /// <summary>The program.</summary>
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DatabaseSettings databaseSettings = new DatabaseSettings();
            Settings.Initialize();
            Application.Run(new MainMenuForm());
        }
    }
}
