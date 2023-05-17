using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
	public class Request
	{
		public MySqlDataReader SqlRequest(string query, MySqlConnection mySqlConnection)
		{
			MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);

			MySqlDataReader mySqlDataReader= mySqlCommand.ExecuteReader();

			return mySqlDataReader;
		}
	}
}
