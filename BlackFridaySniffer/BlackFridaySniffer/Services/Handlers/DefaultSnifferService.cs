using BlackFridaySniffer.Data;
using BlackFridaySniffer.Models;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackFridaySniffer.Services.Handlers
{
    public class DefaultSnifferService : ISnifferService
    {
        IWebDriver _driver;
        IProductRepository _productRepository;

        public DefaultSnifferService(IWebDriver driver, IProductRepository productRepository)
        {
            _driver = driver;
            _productRepository = productRepository;
        }

        public double GetPrice(string productUrl, string priceXPath)
        {
            _driver.Url = productUrl;
            var element = _driver.FindElement(By.XPath(priceXPath));
            var text = element.Text.Replace("R$", "").Trim();

            var price = double.Parse(text, new CultureInfo("pt-br"));
            return price;
        }

        public IEnumerable<Product> SniffPrices()
        {
            List<Product> goodPrices = new List<Product>();
            foreach (var product in _productRepository.ReadAll())
            {
                double price = GetPrice(product.Url, product.PriceXPath);
                if (price <= product.MaximumPrice)
                {
                    product.CurrentPrice = price;
                    goodPrices.Add(product);
                }
            }
            return goodPrices;
        }
    }
}
