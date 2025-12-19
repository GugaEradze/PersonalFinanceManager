using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PFM.Infrastructure.Data;
using PFM.Core.Interfaces;
using PFM.Infrastructure.Repositories;

namespace PFM.UI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);
            var serviceProvider = services.BuildServiceProvider();

            var mainForm = serviceProvider.GetRequiredService<MainForm>();
            System.Windows.Forms.Application.Run(mainForm);
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            string dbPath = System.IO.Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "PersonalFinanceManager",
                "finance.db"
            );

            System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(dbPath)!);

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlite($"Data Source={dbPath}"));

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            services.AddTransient<MainForm>();
            services.AddTransient<AddEditTransactionForm>();
            services.AddTransient<CategoriesForm>();
            services.AddTransient<MonthlyReportForm>();
        }
    }
}