using BookLibrary;
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

namespace FinalManager
{
    public partial class UpdateItem : Window
    {

        public Booklibary2 booklibary2;
        private string _selectedItemName;


        public UpdateItem(string selectedItemName)
        {
            InitializeComponent();
            booklibary2= new Booklibary2();
            _selectedItemName = selectedItemName;

            movieGener.ItemsSource = new string[] { "Thriller", "Horror", "Action", "Romance", "Fantasy", "Comedy" };
            ItemType.ItemsSource = new string[] { "Movie", "Book" };

            Item item = booklibary2.Items.First(x => x.Name == selectedItemName);
            movieName.Text = item.Name;
            moviePrice.Text = item.Price.ToString();
            movieGener.Text = item.Geners.ToString();
            movieDescription.Text = item.Description.ToString();
            movieDiscount.Text = item.Discount.ToString();
            movieStock.Text = item.Stock.ToString();
            movieCreated.Text = item.Created.ToString();
        }

        private void movieName_GotFocus(object sender, RoutedEventArgs e)
        {
            if (movieName.Text == "Name")
            {
                movieName.Text = "";
            }
        }

        private void moviePrice_GotFocus(object sender, RoutedEventArgs e)
        {
            if (moviePrice.Text == "Price")
                moviePrice.Text = "";
        }

        //private void movieGener_GotFocus(object sender, RoutedEventArgs e)
        //{
        //    movieGener.Text = "";
        //}

        private void movieDescription_GotFocus(object sender, RoutedEventArgs e)
        {
            if (movieDescription.Text == "Description")
                movieDescription.Text = "";
        }

        private void movieDiscount_GotFocus(object sender, RoutedEventArgs e)
        {
            if (movieDiscount.Text == "Discount")
                movieDiscount.Text = "";
        }

        private void movieStock_GotFocus(object sender, RoutedEventArgs e)
        {
            if (movieStock.Text == "Stock")
                movieStock.Text = "";
        }


        private void movieName_LostFocus(object sender, RoutedEventArgs e)
        {
            if (movieName.Text == "")
            {
                movieName.Text = "Name";
            }
        }

        private void moviePrice_LostFocus(object sender, RoutedEventArgs e)
        {
            if (moviePrice.Text == "")
            {
                moviePrice.Text = "Price";
            }
        }

        //private void movieGener_LostFocus(object sender, RoutedEventArgs e)
        //{
        //    if (movieGener.Text == "")
        //    {
        //        movieGener.Text = "Gener";
        //    }

        //}

        private void movieDescription_LostFocus(object sender, RoutedEventArgs e)
        {
            if (movieDescription.Text == "")
            {
                movieDescription.Text = "Description";
            }
        }

        private void movieDiscount_LostFocus(object sender, RoutedEventArgs e)
        {
            if (movieDiscount.Text == "")
            {
                movieDiscount.Text = "Discount";
            }
        }

        private void movieStock_LostFocus(object sender, RoutedEventArgs e)
        {
            if (movieStock.Text == "")
            {
                movieStock.Text = "Stock";
            }
        }


        private void BackMain_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void UpdateItemB_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string name = movieName.Text;
                double price = double.Parse(moviePrice.Text);
                Gener gener;
                Enum.TryParse<Gener>(movieGener.Text, out gener);
                string description = movieDescription.Text;
                int discount = int.Parse(movieDiscount.Text);
                int stock = int.Parse(movieStock.Text);
                string created = movieCreated.Text;
                if (created == "")
                {
                    created = DateTime.Now.ToString();
                }

                booklibary2.Items.Where(x => x.Name == _selectedItemName).Select(x => {
                    x.Name = name;
                    x.Price = price;
                    x.Geners = gener;
                    x.Description = description;
                    x.Discount = discount;
                    x.Stock = stock;
                    x.Created = created;
                    return x;
                }).ToList();
                booklibary2.DBService.SaveData(booklibary2.Items);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Please fill in the fields");
                Logger logger = new Logger();
                logger.WriteLog(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please fill in the fields");
                Logger logger = new Logger();
                logger.WriteLog(ex.Message);
            }
        }
    }
}
