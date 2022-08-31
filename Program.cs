using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using SPDB_MKII.Classes;
using SPDB_MKII.Classes.DatabaseInfos;
using SPDB_MKII.Forms;
using System.Diagnostics;

namespace SPDB_MKII
{
    internal static class Program
    {
        static IServiceProvider? serviceProvider = null;

        public static IServiceProvider ServiceProvider
        {
            get
            {
                if (serviceProvider != null)
                {
                    return serviceProvider;
                }

                serviceProvider = ConfigureServices();

                return serviceProvider;
            }
        }

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

        private static ServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            // Replace with your server version and type.
            // Use 'MariaDbServerVersion' for MariaDB.
            // Alternatively, use 'ServerVersion.AutoDetect(connectionString)'.
            // For common usages, see pull request #1233.
            var serverVersion = ServerVersion.AutoDetect(DatabaseCollection.ActiveDatabase.ConnectionString);

            services.AddDbContext<DatabaseContext>(
                dbContextOptions => dbContextOptions
                    .UseMySql(DatabaseCollection.ActiveDatabase.ConnectionString, serverVersion)
                    .LogTo(Console.WriteLine, LogLevel.Information)
                    .EnableSensitiveDataLogging()
                    .EnableDetailedErrors()
            );

            return services.BuildServiceProvider();
        }
    }
}