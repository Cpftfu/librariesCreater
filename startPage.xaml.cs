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
	/// Логика взаимодействия для startPage.xaml
	/// </summary>
	public partial class startPage : Window
	{
		public startPage()
		{
			InitializeComponent();
		}

		private void for_themes_Click(object sender, RoutedEventArgs e)
		{
			forThemesPage window1 = new forThemesPage();
			window1.Show();
			Close();
        }

		private void for_de_cerialization_Click(object sender, RoutedEventArgs e)
		{
			forDeCerializationPage window2 = new forDeCerializationPage();
			window2.Show(); 
			Close();
		}
	}
}
