using HotelSuperbl.Models;
using HotelSuperbl.ViewModels;
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

namespace HotelSuperbl.Views
{
    /// <summary>
    /// Логика взаимодействия для Accommodation.xaml
    /// </summary>
    public partial class AccommodationView : Page
    {
        AccommodationViewModel Accommodation;
        public AccommodationView()
        {
            InitializeComponent();
            Accommodation = new AccommodationViewModel();
            DataContext = Accommodation;
            using (var context = new HotelContext())
            {
                DataGridAccommodations.ItemsSource = context.Accommodations.ToList();
            }
        }
        private void ClickAddAccommodation(object sender, RoutedEventArgs e)
        {
            AddAccommodationView addAccommodationView = new AddAccommodationView();
            NavigationService.Navigate(new Uri("/Views/AddAccommodationView.xaml", UriKind.Relative));

        }
    }
}
        

       

    

