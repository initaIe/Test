using DAL;
using DAL.Test;
using Domain.Test.Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Test
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public int userId;
		public int userRole;
		public MySqlConnection defaultConnection;

		public MainWindow()
		{
			InitializeComponent();

			OpenConnection openConnection = new OpenConnection();
			defaultConnection = openConnection.OpenSqlConnection();	

			frame.Navigate(new Pages.Authorization(this));
		}
	}
}
