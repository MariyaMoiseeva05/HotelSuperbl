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

namespace HotelSuperbl
{
    /// <summary>
    /// Логика взаимодействия для OR.xaml
    /// </summary>
    public partial class OR : Page
    {
        public OR()
        {
            InitializeComponent();
        }

        private void Button_ClickSearch(object sender, RoutedEventArgs e)
        {
           SearchRoom searchRoom = new SearchRoom();
            this.NavigationService.Navigate(searchRoom);
            int index = int.Parse(((Button)e.Source).Uid);

            GridCursor.Margin = new Thickness(0 + (200 * index), 45, 0, 462);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            

        }

        private void ButtonClickCreate_Reservation(object sender, RoutedEventArgs e)
        {
            CreateReservation createReservation = new CreateReservation();
            this.NavigationService.Navigate(createReservation);

            int index = int.Parse(((Button)e.Source).Uid);

            GridCursor.Margin = new Thickness(80 + (200 * index),  45, 0, 462);

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
