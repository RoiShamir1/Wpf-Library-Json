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
    /// <summary>
    /// Interaction logic for AddMoviesP.xaml
    /// </summary>
    public partial class AddMoviesP : Window
    {
        public Booklibary2 booklibary2;
        //private DbService shopDbService;
        //private DbService userLoginService;

        /// <summary>
        /// החלון להוספת פריט נקרא הוספת סרט אבל מתייחס להוספת כלל סוגי הפריטים
        /// ניתן לבחור את סוג הפריט באמצעות כפתור הקומבובוקס
        /// </summary>
        public AddMoviesP()
        {
            InitializeComponent();
            booklibary2 = new Booklibary2();
            //shopDbService = new DbService("ShopDB.json");
            // userLoginService = new DbService("UsersDB.json");
            
            movieGener.ItemsSource = new string[] { "Thriller", "Horror", "Action", "Romance", "Fantasy", "Comedy" };
            ItemType.ItemsSource = new string[] { "Movie", "Book" };
        }



        // פונקציות קצרות כאשר מתמקדים/לא מתמקדים בחלון
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


        private void AddMovie_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string type = ItemType.Text;
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

                if (type == "Movie")
                {
                    Movie movie = new Movie(type, name, price, gener, description, discount, stock,created);
                    booklibary2.Items.Add(movie);
                    booklibary2.DBService.SaveData(booklibary2.Items);
                }
                else
                {
                    Book book = new Book(type, name, price, gener, description, discount, stock, created);
                    booklibary2.Items.Add(book);
                    booklibary2.DBService.SaveData(booklibary2.Items);
                }
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
