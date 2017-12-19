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

namespace WPFЗаданиеLeet
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		/// <summary>
		/// By pressing there is a transfer
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				this.TxtTranslate.Clear();
				Translate tr = new Translate();
				if (this.RbToLeet.IsChecked == true)
				{
					foreach (var i in this.Txt.Text.ToUpper())
					{
						tr.ToLeet(i.ToString());
						if (tr.Result != null)
							this.TxtTranslate.Text += tr.Result;
						else
							this.TxtTranslate.Text += i.ToString().ToLower();
					}
				}
				if(this.RbToEnglish.IsChecked == true)
				{
					foreach(var i in this.Txt.Text.ToUpper())
					{
						tr.ToEnglish(i.ToString());
						if (tr.Result != null)
							this.TxtTranslate.Text += tr.Result.ToLower();
						else
							this.TxtTranslate.Text += i.ToString().ToLower();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
