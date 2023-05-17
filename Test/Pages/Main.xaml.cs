using DAL.Test;
using Domain.Test.Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Test.Pages
{
	/// <summary>
	/// Interaction logic for Main.xaml
	/// </summary>
	public partial class Main : Page
	{
		MainWindow mainWindow;
		public Main(MainWindow _mainWindow)
		{
			InitializeComponent();
			mainWindow = _mainWindow;

			LoadData();
		}


		public void LoadData()
		{
			User.users.Clear();

			Request request = new Request();
			MySqlDataReader allUsers = request.SqlRequest("SELECT * FROM `Users`", mainWindow.defaultConnection);

			while (allUsers.Read())
			{
				User.users.Add(new Domain.Test.Entity.User(
					Convert.ToInt32(allUsers.GetValue(0)),
					allUsers.GetValue(1).ToString(),
					allUsers.GetValue(2).ToString(),
					allUsers.GetValue(3).ToString(),
					Convert.ToInt32(allUsers.GetValue(4)),
					allUsers.GetValue(5).ToString(),
					allUsers.GetValue(6).ToString()
					));
			}

			for (int i = 0; i < User.users.Count; i++)
			{
				var Grid = new Grid
				{
					Background = new SolidColorBrush(Colors.GhostWhite),
					Margin = new Thickness(0, 5, 0, 5),
					Height = 300,
				};

				Label label = new Label
				{
					Content = User.users[i].Login
				};

				var button1 = new Button();

				button1.Tag = i;
				button1.Click += delegate
				{
					int id = User.users[Convert.ToInt32(button1.Tag.ToString())].Id;
					MessageBox.Show(id.ToString());
				};




				Grid.Children.Add(label);
				Grid.Children.Add(button1);
				Parent.Children.Add(Grid);
			}
		}
	}
}
