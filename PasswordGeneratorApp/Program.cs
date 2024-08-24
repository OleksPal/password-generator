using Microsoft.Extensions.DependencyInjection;
using PasswordGeneratorApp.Generator;
using System;
using System.Windows.Forms;

namespace PasswordGeneratorApp
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection()
                .AddSingleton<IPasswordGeneratable, PasswordGenerator>()
                .AddSingleton<MainForm>();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using var serviceProvider = services.BuildServiceProvider();
            MainForm mainForm = serviceProvider.GetService<MainForm>();
            
            Application.Run(mainForm);
        }
    }
}
