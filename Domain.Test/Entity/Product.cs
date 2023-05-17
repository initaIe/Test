using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Test.Entity
{
	public class Product
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string Category { get; set; }
		public string Article { get; set; }
		public string Manufacturer { get; set; }
		public int Discount { get; set; }
		public int Cost { get; set; }
		public int Amount { get; set; }
	}
}
