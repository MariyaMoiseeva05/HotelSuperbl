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
    /// Логика взаимодействия для Room_categoryView.xaml
    /// </summary>
    public partial class Room_categoryView : Page
    {
        Room_categoryViewModel Room_category;
        public Room_categoryView()
        {
            InitializeComponent();
            Room_category = new Room_categoryViewModel();
            DataContext = Room_category;
            using (var context = new HotelContext())
            {
                DataGridRoom_category.ItemsSource = context.Room_category.ToList();
            }

        }
    }
}
