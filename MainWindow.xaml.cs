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
using BookLibrary;
using System.ComponentModel;


namespace FinalManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Booklibary2 booklibary2;
       // private DbService shopDbService;
        //private DbService userLoginService;
        private string selectedItemName;


        public MainWindow()
        {
            InitializeComponent();
            booklibary2 = new Booklibary2();
            //shopDbService = new DbService("ShopDB.json");
           // userLoginService = new DbService("UsersDB.json");
            //var items = booklibary2.DBService.GetData();
            //if (items == null)
            //{
            //    items = new List<Item>();
            //}
            MyList.ItemsSource = booklibary2.Items;
            SortBy.ItemsSource = new string[] { "Name", "Stock" , "Price" };


            //מיון לפי שם
            SortBy.SelectionChanged += SortBy_SelectionChanged;
            MyList.Items.SortDescriptions.Add(new SortDescription("Name", ListSortDirection.Ascending));

        }

        //מיון רשימה
        private void SortBy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SortList();
        }

        public void SortList()
        {
            var SortProperty = SortBy.SelectedItem.ToString();

            MyList.Items.SortDescriptions[0] = new SortDescription(SortProperty, ListSortDirection.Ascending);
        }


        private void MoveMovieP_Click(object sender, RoutedEventArgs e)
        {
            AddMoviesP addMoviesP = new AddMoviesP();
            addMoviesP.Show();
            Close();
        }


        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        //מעדכן את המוצר שנבחר
        private void UpdateItem_Click(object sender, RoutedEventArgs e)
        {
            //Item item = booklibary2.Items.First(x => x.ISBN == selectedItemISBN);

            UpdateItem updateMovie = new UpdateItem(selectedItemName);
            updateMovie.Show();
            Close();
        }


        //מחיקת  פריט לאחר שנבחר
        private void DeleteItem_Click(object sender, RoutedEventArgs e)
        {

            booklibary2.Items.Remove((Item)MyList.SelectedItem);
            booklibary2.DBService.SaveData(booklibary2.Items);
            MyList.ItemsSource = booklibary2.Items;
        }

        private void MyList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Item i  = e.AddedItems[0] as Item;
            selectedItemName = i.Name;
        }

        //מציג דוח לקובץ גייסון
        private void Report_Click(object sender, RoutedEventArgs e)
        {
            Report report = new Report();
            foreach (Item item in booklibary2.Items)
            {
                if (item.Discount > 20)
                {
                    report.Items.Add(item);
                    report.DbReport.SaveData(report.Items);
                }
            }
        }
    }
}
