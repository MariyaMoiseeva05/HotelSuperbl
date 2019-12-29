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
    /// Логика взаимодействия для SearchService_check.xaml
    /// </summary>
    public partial class SearchService_check : Page
    {
        public SearchService_check()
        {
            InitializeComponent();
            DataContext = new Service_checkViewModel();
        }

        private void ButtonServSearch_Click(object sender, EventArgs e)
        {
            dataGridViewClientSearch.ItemsSource =ReportsViewModel.ExecuteSP((DateTime)DateTimePicker1.DisplayDate, (int)ComboboxSurname.SelectedValue);
        }

    }
}
