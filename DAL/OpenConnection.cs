using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
	public class OpenConnection
	{
		public MySqlConnection OpenSqlConnection()
		{
			MySqlConnection mySqlConnection = new MySqlConnection();

			mySqlConnection.Open();

			return mySqlConnection;
		}
	}
}
