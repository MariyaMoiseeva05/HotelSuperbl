using HotelSuperbl.Models;
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
    public class Additional_servicesViewModel : INotifyPropertyChanged
    {

        private Additional_services selectedAdditional_services;
        public ObservableCollection<Additional_services> Additional_services { get; set; }
        public Additional_servicesViewModel()
        {
            Additional_services = new ObservableCollection<Additional_services>();
        }
        public Additional_services SelectedAdditional_services
        {
            get { return selectedAdditional_services; }
            set
            {
                selectedAdditional_services = value;
                OnPropertyChanged(" SelectedAdditional_services");
            }
        }
       
        private Additional_services additional_services;

        public Additional_servicesViewModel(Additional_services ads)
        {
            additional_services = ads;
        }

        public int ID_additional_services
        {
            get { return additional_services.ID_additional_services; }
            set
            {
                additional_services.ID_additional_services = value;
                OnPropertyChanged("Код услуги");
            }
        }
        public string Name
        {
            get { return additional_services.name; }
            set
            {
                additional_services.name = value;
                OnPropertyChanged("Название");
            }
        }
        public string Description
        {
            get { return additional_services.description; }
            set
            {
                additional_services.description = value;
                OnPropertyChanged("Описание");
            }
        }
        public decimal Current_price
        {
            get { return additional_services.current_price; }
            set
            {
                additional_services.current_price = value;
                OnPropertyChanged("Стоимость");
            }
        }
        public TimeSpan Beginning_of_work
        {
            get { return additional_services.beginning_of_work; }
            set
            {
                additional_services.beginning_of_work = value;
                OnPropertyChanged("Начало рабочего дня");
            }
        }
        public TimeSpan End_of_work
        {
            get { return additional_services.end_of_work; }
            set
            {
                additional_services.end_of_work = value;
                OnPropertyChanged("Конец рабочего дня");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }



    }

}






