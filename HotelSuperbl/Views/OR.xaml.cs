using HotelSuperbl.Models;
using HotelSuperbl.ViewModels;
using HotelSuperbl.Views;
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
        ReservationViewModel Reservation;
        ClientViewModel Client;
        Hotel_roomViewModel Hotel_room;
        Additional_servicesViewModel Additional_services;
        public OR()
        {
            InitializeComponent();
            Reservation = new ReservationViewModel();
            DataContext = Reservation;
            using (var context = new HotelContext())
            {
                DataGridReservation.ItemsSource = context.Reservations.ToList();
            }
            
            Client = new ClientViewModel();
            DataContext = Client;
            using (var context = new HotelContext())
            {
                DataGridClient.ItemsSource = context.Clients.ToList();
            }

            Hotel_room = new Hotel_roomViewModel();
            DataContext = Hotel_room;
            using (var context = new HotelContext())
            {
                DataGridHotel_room.ItemsSource = context.Hotel_room.ToList();
            }

            Additional_services = new Additional_servicesViewModel();
            DataContext = Additional_services;
            using (var context = new HotelContext())
            {
                DataGridAdditional.ItemsSource = context.Additional_services.ToList();
            }
        }

    

        private void CreateReservation(object sender, RoutedEventArgs e)
        {
            CreateReservation createReservation = new CreateReservation();
            NavigationService.Navigate(new Uri("/Views/CreateReservation.xaml", UriKind.Relative));

        }

        private void ClickAccommodation(object sender, RoutedEventArgs e)
        {
            AccommodationView accommodationView = new AccommodationView();
            NavigationService.Navigate(new Uri("/Views/AccommodationView.xaml", UriKind.Relative));
        }

        private void ClickRoom_category(object sender, RoutedEventArgs e)
        {
            Room_categoryView room_categoryView = new Room_categoryView();
            NavigationService.Navigate(new Uri("/Views/Room_categoryView.xaml", UriKind.Relative));
        }

        private void AddClient(object sender, RoutedEventArgs e)
        {
            AddClient addClient = new AddClient();
            NavigationService.Navigate(new Uri("/Views/AddClient.xaml", UriKind.Relative));
        }

        private void Service_checkView(object sender, RoutedEventArgs e)
        {
            Service_checkView service_CheckView = new Service_checkView();
            NavigationService.Navigate(new Uri("/Views/Service_checkView.xaml", UriKind.Relative));
        }
        
        private void SearchReservation(object sender, RoutedEventArgs e)
        {
            SearchReservation searchReservation = new SearchReservation();
            NavigationService.Navigate(new Uri("/Views/SearchReservation.xaml", UriKind.Relative));
        }
        
        
      
         
           

    }
}
