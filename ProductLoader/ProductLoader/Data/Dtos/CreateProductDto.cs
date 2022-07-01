using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLoader.Data.Dtos
{
    public class CreateProductDto
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string PriceXPath { get; set; }
        public double MaximumPrice { get; set; }
        public double DesiredPrice { get; set; }
    }
}
