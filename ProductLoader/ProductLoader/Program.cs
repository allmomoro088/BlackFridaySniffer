using BlackFridaySniffer.Data;
using BlackFridaySniffer.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProductLoader.Services;
using ProductLoader.Services.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductLoader
{
    static class Program
    {
        private static IConfiguration Configuration { get; set; }
        static IServiceCollection ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddDbContext<AppDbContext>(opt => opt.UseMySQL(Configuration.GetConnectionString("mysql")));
            services.AddTransient<IProductService, DefaultProductService>();
            services.AddTransient<IProductRepository, ProductRepository>();

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            return services;
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            Configuration = builder.Build();
            var services = ConfigureServices();
            var provider = services.BuildServiceProvider();
            var productService = provider.GetService<IProductService>();

            Application.Run(new Form(productService));
        }
    }
}
