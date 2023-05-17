using DAL.Test;
using Domain.Test.Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
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
	/// Interaction logic for Authorization.xaml
	/// </summary>
	public partial class Authorization : Page
	{
		MainWindow mainWindow;
		public Authorization(MainWindow _mainWindow)
		{
			InitializeComponent();
			mainWindow = _mainWindow;
		}

		private void OnAuthorization(object sender, RoutedEventArgs e)
		{
			mainWindow.frame.Navigate(new Pages.Main(mainWindow));			
		}
	}
}
