using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
	public class Order
	{
		public int Id { get; set; }
		public int Status { get; set; }
		public int PickupPoint { get; set; }
		public string? DeveleryDate { get; set; }
	}
}
