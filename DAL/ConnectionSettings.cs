using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
	public class ConnectionSettings
	{
		const string Server = "192.168.1.102";
		const string Port = "2288";
		const string Uid = "root";
		const string Pwd = "";
		const string Database = "test";

		const string connectionString = $"server={Server};port={Port};uid={Uid};pwd={Pwd};database{Database};";
	}
}
