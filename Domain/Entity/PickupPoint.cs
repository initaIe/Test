﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
	public class PickupPoint
	{
		public int Id { get; set; }
		public string? City { get; set; }
		public string? Street { get; set; }
		public string? House { get; set; }
	}
}
