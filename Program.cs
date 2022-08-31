using Serilog;
using SPDB_MKII.Forms;
using System.Diagnostics;

namespace SPDB_MKII
{
    internal static class Program
    {
        public static bool DebugEnabled { get => AppSettings.DebugEnabled; }

        public static Properties.Settings AppSettings
        {
            get => Properties.Settings.Default;

        }

        private static Serilog.Core.Logger? logger = null;

        public static Serilog.Core.Logger Log
        {
            get
            {
                if(logger == null) 
                {
                    Debug.WriteLine("Initializing the logger.");

                    logger = new LoggerConfiguration()
                        .MinimumLevel.Debug()
                        .WriteTo.Console()
                        .WriteTo.Debug()
                        //.WriteTo.File(@"F:\log.txt")
                        .CreateLogger();

                    logger.Information("Logger initialized.");
                }

                return logger;
            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // ------------------------------------------------------
            // READ THIS FOR THE DB ABSTRACTION USAGE
            // https://docs.microsoft.com/en-us/ef/core/
            // ------------------------------------------------------

            Application.Run(new DBSelection());
        }
    }
}