using BlackFridaySniffer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackFridaySniffer.Data
{
    public class AppDbContext : DbContext
    {
		public AppDbContext(DbContextOptions opts) : base (opts)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
