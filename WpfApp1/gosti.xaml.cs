using System;
using System.Collections.Generic;
using System.Data;
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

namespace WpfApp1
{
	/// <summary>
	/// Логика взаимодействия для gosti.xaml
	/// </summary>
	public partial class gosti : Page
	{
        public gosti()
		{

            InitializeComponent();

			var allManufacturer = TradeEntities1.getContext().Product.ToList();
			allManufacturer.Insert(0, new Product
			{
				ProductManufacturer = "Все типы"
			});
			ComboManufacturer.ItemsSource = allManufacturer;
			ComboManufacturer.SelectedIndex = 0;

            TradeEntities1 tradeEntities = new TradeEntities1();

			UpdateProduct();
		}

		private void UpdateProduct()
		{
			var currentProduct = TradeEntities1.getContext().Product.ToList();

			if (ComboManufacturer.SelectedIndex > 0)

				currentProduct = currentProduct.Where(p => p.ProductManufacturer.Contains(ComboManufacturer.Text)).ToList();

			currentProduct = currentProduct.Where(p => p.ProductName.ToLower().Contains(tbxSearch.Text.ToLower())).ToList();

			 

			listView.ItemsSource = currentProduct.OrderBy(p => p.ProductArticleNumber).ToList();
		}
		private void btn_Exit(object sender, RoutedEventArgs e)
		{
            MainWindow windowPage2 = new MainWindow();
            windowPage2.Show();
            App.Current.Windows[0].Close();
        }

		private void tbxSerch_changed(object sender, TextChangedEventArgs e)
		{
			UpdateProduct();

        }

		private void ComboType_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			UpdateProduct();

        }
	}
}
