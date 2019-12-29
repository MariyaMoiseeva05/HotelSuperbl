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
    /// Логика взаимодействия для NewUsluga.xaml
    /// </summary>
    public partial class NewUsluga : Page
    {
        public NewUsluga()
        {
        }

        public NewUsluga(HotelContext context)
        {
            InitializeComponent();
            DataContext = new NewUslugaViewModel(context, this);
        }
    }
}
