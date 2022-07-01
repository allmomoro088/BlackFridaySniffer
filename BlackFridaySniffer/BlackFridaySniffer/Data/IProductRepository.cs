using BlackFridaySniffer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackFridaySniffer.Data
{
	public interface IProductRepository : IQuery<Product>, IInsertCommand<Product>, IDeleteCommand<Product>
	{
		
	}
}
