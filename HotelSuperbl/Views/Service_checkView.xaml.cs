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
    /// Логика взаимодействия для Service_check.xaml
    /// </summary>
    public partial class Service_checkView : Page
    {
        Service_checkViewModel Service_check;
        public Service_checkView()
        {
            InitializeComponent();
            Service_check = new Service_checkViewModel();
            DataContext = Service_check;
            using (var context = new HotelContext())
            {
                DataGridOkazUsl.ItemsSource = context.Service_check.ToList();
            }
        }
        
        
        private void ClickButtonAddAdServCl(object sender, RoutedEventArgs e)
            {
                NewUsluga newUsluga = new NewUsluga();
                NavigationService.Navigate(new Uri("/Views/NewUsluga.xaml", UriKind.Relative));

            }

        
    }
}
