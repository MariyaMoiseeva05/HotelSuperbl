using HotelSuperbl.Helpers;
using HotelSuperbl.Models;
using HotelSuperbl.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HotelSuperbl.ViewModels
{

    public class Service_checkViewModel : INotifyPropertyChanged
    {

        private Service_check selectedService_check;
        public ObservableCollection<Service_check> Service_check { get; set; }

        public Service_checkViewModel()
        {
            Service_check = new ObservableCollection<Service_check>();
        }
        public Service_check SelectedService_check
        {
            get { return selectedService_check; }
            set
            {
                selectedService_check = value;
                OnPropertyChanged("SelectedService_check");
            }
        }
       
       /* //команда поиска оказанной услуги
        private RelayCommand addCommandAds;
        public RelayCommand AddCommandAds
        {
            get
            {
                return addCommandAds ??
                  (addCommandAds = new RelayCommand(obj =>
                  {
                     SearchService_check searchService_Check = new SearchService_check();
                      Service_check.Insert(0, service_Check);
                      SelectedService_check = service_Check;
                  }));
            }
        }
        */
       

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        private Service_check service_Check;

        public Service_checkViewModel(Service_check sh)
        {
            service_Check = sh;
        }

        public int Id_check
        {
            get { return service_Check.id_check; }
            set
            {
                service_Check.id_check = value;
                OnPropertyChanged("Код платежа");
            }
        }
        public int Id_client
        {
            get { return service_Check.id_client; }
            set
            {
                service_Check.id_client = value;
                OnPropertyChanged("Код клиента");
            }
        }

        public int Id_addition_services
        {
            get { return service_Check.id_addition_services; }
            set
            {
                service_Check.id_addition_services = value;
                OnPropertyChanged("Код услуги");
            }
        }

        public DateTime Date
        {
            get { return service_Check.date; }
            set
            {
                service_Check.date = value;
                OnPropertyChanged("Дата заказа");
            }
        }

        public int Quantity
        {
            get { return service_Check.quantity; }
            set
            {
                service_Check.quantity = value;
                OnPropertyChanged("Количество");
            }
        }

        public decimal Cost_service
        {
            get { return service_Check.cost_service; }
            set
            {
                service_Check.cost_service = value;
                OnPropertyChanged("Стоимость");
            }
        }

        public bool Payment
        {
            get { return service_Check.payment; }
            set
            {
                service_Check.payment = value;
                OnPropertyChanged("Оплата");
            }
        }

    }
}