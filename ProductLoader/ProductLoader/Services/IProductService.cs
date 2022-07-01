using BlackFridaySniffer.Models;
using ProductLoader.Data.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLoader.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetProducts();
        Product GetProduct(string id);
        void RemoveProduct(Product product);
        Product CreateProduct(CreateProductDto dto);
    }
}
