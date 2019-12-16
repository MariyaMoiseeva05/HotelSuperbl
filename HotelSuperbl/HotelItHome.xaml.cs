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
    /// Логика взаимодействия для HotelItHome.xaml
    /// </summary>
    public partial class HotelItHome : Page
    {
        public HotelItHome()
        {
            InitializeComponent();
        }
       
            private void Button_Click1(object sender, RoutedEventArgs e)
            {
                LoginPassword loginPassword = new LoginPassword();
                this.NavigationService.Navigate(loginPassword);

                // View Expense Report
                // Report occupancyReportPage = new Report();
                //  this.NavigationService.Navigate(occupancyReportPage);
            }
        }
}
