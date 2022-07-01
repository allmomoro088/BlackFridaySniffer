using BlackFridaySniffer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackFridaySniffer.Services
{
    public interface ISnifferService
    {
        double GetPrice(string productUrl, string priceXPath);
        IEnumerable<Product> SniffPrices();
    }
}
