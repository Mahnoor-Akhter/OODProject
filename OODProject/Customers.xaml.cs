﻿using System;
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

namespace OODProject
{
	/// <summary>
	/// Interaction logic for Customers.xaml
	/// </summary>
	public partial class Customers : Window
	{
		public Customers()
		{
			InitializeComponent();
		}
		private void btn5_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}
	}
}
