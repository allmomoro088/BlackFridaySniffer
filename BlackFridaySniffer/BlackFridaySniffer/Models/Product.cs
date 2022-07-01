using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackFridaySniffer.Models
{
    public class Product
    {
        [Key]
        [Required]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Url { get; set; }
        [Required]
        public string PriceXPath { get; set; }
        [Required]
        public double MaximumPrice { get; set; }
        [Required]
        public double DesiredPrice { get; set; }
        [NotMapped]
        public double CurrentPrice { get; set; }

		public override string ToString()
		{
			return Name.ToString();
		}
	}
}
