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

namespace WriteReadProjectDemo
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        List<Product> products = new List<Product>();
        public Window1()
        {
            InitializeComponent();       
            //this.articleProducts = articleProducts;
            //List<string> articleProducts = new List<string>();

            foreach (Product product in db.tbe.Product.ToList())
            {
                foreach(string item in PageProducts.articleProducts)
                {
                    if(product.ProductArticleNumber == item)
                    {
                        products.Add(product);
                    }
                }
            }
            lvView.ItemsSource = products;
            lvView.SelectedValuePath = "ProductArticleNumber";
        }
        // 
        private void dasd_Click(object sender, RoutedEventArgs e)
        {
            foreach(Product item in products)
            {
                MessageBox.Show(item.ProductArticleNumber);
            }
          
        }
    }
}
