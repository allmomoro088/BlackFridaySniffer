using BlackFridaySniffer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackFridaySniffer.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

		public void Insert(Product product)
		{
            _context.Products.Add(product);
            _context.SaveChanges();
		}

		public Product Read(string id)
		{
			return _context.Products.FirstOrDefault(x => x.Id == id);
		}

		public IEnumerable<Product> ReadAll()
        {
            return _context.Products.ToList();
        }

		public void Remove(Product obj)
		{
			_context.Products.Remove(obj);
            _context.SaveChanges();
		}
	}
}
