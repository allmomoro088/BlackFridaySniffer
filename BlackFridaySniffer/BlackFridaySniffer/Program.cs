using BlackFridaySniffer.Data;
using BlackFridaySniffer.Data.Repositories;
using BlackFridaySniffer.Models;
using BlackFridaySniffer.Services;
using BlackFridaySniffer.Services.Handlers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Pomelo.EntityFrameworkCore.MySql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace BlackFridaySniffer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {

                    IConfiguration configuration = hostContext.Configuration;

                    var opts = new DbContextOptionsBuilder<AppDbContext>();
                    opts.UseMySql(configuration.GetConnectionString("mysql"), ServerVersion.AutoDetect(configuration.GetConnectionString("mysql")));

                    services.AddSingleton<AppDbContext>(s => new AppDbContext(opts.Options));
                    services.AddTransient((s) => configuration.GetSection("TwilioSettings").Get<TwilioSettings>());

                    string driverPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                    services.AddTransient<ISnifferService, DefaultSnifferService>();
                    services.AddTransient<ISMSService, DefaultSMSService>();
                    services.AddTransient<IProductRepository, ProductRepository>();

                    var opt = new ChromeOptions();
                    opt.AddArguments(new List<string> { "headless" , "silent", "disable-gpu", "log-level=3"});

                    services.AddTransient<IWebDriver>((s) => new ChromeDriver(driverPath, opt));
                    services.AddHostedService<Worker>();
                });
    }
}
