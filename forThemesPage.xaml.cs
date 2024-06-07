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
using System.Windows.Shapes;

namespace LibraryCreateWPF
{
	/// <summary>
	/// Логика взаимодействия для forThemesPage.xaml
	/// </summary>
	public partial class forThemesPage : Window
	{
		public forThemesPage()
		{
			InitializeComponent();
		}

		private void for_romantic_Click(object sender, RoutedEventArgs e)
		{

		}

		private void for_forest_Click(object sender, RoutedEventArgs e)
		{

		}

		private void for_technological_Click(object sender, RoutedEventArgs e)
		{

		}

		private void for_vintage_Click(object sender, RoutedEventArgs e)
		{

		}

		private void for_space_Click(object sender, RoutedEventArgs e)
		{

		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			startPage window = new startPage();
			window.Show();
			Close();
		}
	}
}
