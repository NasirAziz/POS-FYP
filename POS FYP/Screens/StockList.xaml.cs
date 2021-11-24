using POS_FYP.Models;
using System.Collections.Generic;
using System.Windows;


namespace POS_FYP.Screens
{
    /// <summary>
    /// Interaction logic for StockList.xaml
    /// </summary>
    public partial class StockList : Window
    {
        public StockList()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dgStock.ItemsSource = LoadCollectionData();
            cbCategory.ItemsSource = LoadCollectionData();
            cbCategory.DisplayMemberPath = "Category";

            cbCategory.SelectedIndex = 0;

        }

        private void btnAddNew_Click(object sender, RoutedEventArgs e)
        {
            AddProduct ap = new AddProduct();
            ap.Show();
        }

        private List<Product> LoadCollectionData()
        {
            List<Product> products = new List<Product>();

            products.Add(new Product()
            {
                ID = 101,
                Name = "Dish Stand",
                Barcode = "01010101010",
                SKU = "A1S4001",
                Supplier = "",
                Category = "Home Appliance",
                Purchase = 1200,
                Retail = 1800,
                Image = "",
                Stock = 40
            });

            products.Add(new Product()
            {
                ID = 101,
                Name = "Olpers",
                Barcode = "01023401010",
                SKU = "A0S0004",
                Supplier = "",
                Category = "Milk n Dairy",
                Purchase = 200,
                Retail = 250,
                Image = "",
                Stock = 80
            }); 
            products.Add(new Product()
            {
                ID = 101,
                Name = "Soap",
                Barcode = "01010101010",
                SKU = "A1S4001",
                Supplier = "",
                Category = "Beauty and hygiene",
                Purchase = 30,
                Retail = 60,
                Image = "",
                Stock = 40
            }); 
            products.Add(new Product()
            {
                ID = 101,
                Name = "Dish Stand",
                Barcode = "01010101010",
                SKU = "A1S4001",
                Supplier = "",
                Category = "Home Appliance",
                Purchase = 1200,
                Retail = 1800,
                Image = "",
                Stock = 40
            });
            products.Add(new Product()
            {
                ID = 101,
                Name = "Dish Stand",
                Barcode = "01010101010",
                SKU = "A1S4001",
                Supplier = "",
                Category = "Home Appliance",
                Purchase = 1200,
                Retail = 1800,
                Image = "",
                Stock = 40
            });

            products.Add(new Product()
            {
                ID = 101,
                Name = "Olpers",
                Barcode = "01023401010",
                SKU = "A0S0004",
                Supplier = "",
                Category = "Milk n Dairy",
                Purchase = 200,
                Retail = 250,
                Image = "",
                Stock = 80
            });
            products.Add(new Product()
            {
                ID = 101,
                Name = "Soap",
                Barcode = "01010101010",
                SKU = "A1S4001",
                Supplier = "",
                Category = "Beauty and hygiene",
                Purchase = 30,
                Retail = 60,
                Image = "",
                Stock = 40
            });
            products.Add(new Product()
            {
                ID = 101,
                Name = "Dish Stand",
                Barcode = "01010101010",
                SKU = "A1S4001",
                Supplier = "",
                Category = "Home Appliance",
                Purchase = 1200,
                Retail = 1800,
                Image = "",
                Stock = 40
            });
            products.Add(new Product()
            {
                ID = 101,
                Name = "Dish Stand",
                Barcode = "01010101010",
                SKU = "A1S4001",
                Supplier = "",
                Category = "Home Appliance",
                Purchase = 1200,
                Retail = 1800,
                Image = "",
                Stock = 40
            });

            products.Add(new Product()
            {
                ID = 101,
                Name = "Olpers",
                Barcode = "01023401010",
                SKU = "A0S0004",
                Supplier = "",
                Category = "Milk n Dairy",
                Purchase = 200,
                Retail = 250,
                Image = "",
                Stock = 80
            });
            products.Add(new Product()
            {
                ID = 101,
                Name = "Soap",
                Barcode = "01010101010",
                SKU = "A1S4001",
                Supplier = "",
                Category = "Beauty and hygiene",
                Purchase = 30,
                Retail = 60,
                Image = "",
                Stock = 40
            });
            products.Add(new Product()
            {
                ID = 101,
                Name = "Dish Stand",
                Barcode = "01010101010",
                SKU = "A1S4001",
                Supplier = "",
                Category = "Home Appliance",
                Purchase = 1200,
                Retail = 1800,
                Image = "",
                Stock = 40
            });
            products.Add(new Product()
            {
                ID = 101,
                Name = "Dish Stand",
                Barcode = "01010101010",
                SKU = "A1S4001",
                Supplier = "",
                Category = "Home Appliance",
                Purchase = 1200,
                Retail = 1800,
                Image = "",
                Stock = 40
            });

            
            return products;
        }
    }
}
