using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Test
{
	public class OpenConnection
	{
		ConnectionSettings connectionSettings = new ConnectionSettings();

		public MySqlConnection OpenSqlConnection()
		{
			MySqlConnection mySqlConnection = new MySqlConnection(connectionSettings.connectionString);

			mySqlConnection.Open();

			return mySqlConnection;
		}
	}
}
