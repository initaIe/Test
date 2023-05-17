using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Test
{
	public class ConnectionSettings
	{
		static string server = "192.168.1.102";
		static string port = "3306";
		static string uid = "initale";
		static string pwd = "initale";
		static string database = "test";

		public string connectionString = $"server={server};port={port};uid={uid};pwd={pwd};database={database}";
	}
}
