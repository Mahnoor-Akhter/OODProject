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
using System.Data.SqlClient;

namespace OODProject
{
	/// <summary>
	/// Interaction logic for items.xaml
	/// </summary>
	public partial class items : Window
	{
		public items()
		{
			InitializeComponent();
		}
		SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\35389\Documents\JewelleryDb.mdf;Integrated Security=True;Connect Timeout=30");
		public string SelectedItem { get; private set; }

		private void cbxcatrgy_Loaded(object sender, RoutedEventArgs e)
		{
			List<string> categories = new List<string>();
			categories.Add("Earings");
			categories.Add("Necklace");
			categories.Add("Ring");
			cbxcatrgy.ItemsSource = categories;
		}

		private void cbxcatrgy_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			string selectedcategories = cbxcatrgy.ItemsSource as string;


		}

		private void cbxtypes_Loaded(object sender, RoutedEventArgs e)
		{
			List<string> types = new List<string>();
			types.Add("Gold");
			types.Add("Silver");
			types.Add("Diamond");
			cbxcatrgy.ItemsSource = types;
		}

		private void cbxtypes_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			string selectedTypes = cbxtypes.ItemsSource as string;
		}

		private void btn4_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}

		private void btnsave_Click(object sender, RoutedEventArgs e)
		{
			if (tbxBName.Text == "" || tbxprice.Text == "" || tbxquantity.Text == "" || cbxcatrgy.SelectedIndex == -1 || cbxtypes.SelectedIndex == -1) 
			{
				MessageBox.Show("Missing Information");
			}
			else
			{
				try
				{
					Con.Open();
					string query = "insert into ItemTbl values( '"+tbxBName.Text+"',' " + cbxcatrgy.SelectedItem.ToString() + "','" + cbxtypes.SelectedItem.ToString() + "'," + tbxprice.Text + "," + tbxquantity.Text + ")";
					SqlCommand cmd = new SqlCommand(query, Con);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Item saved Successfully");
				}
				catch(Exception Ex)
				{
					MessageBox.Show(Ex.Message);
				}
			}
		}
	}
}
