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
using System.Windows;

namespace HotelSuperbl.ViewModels
{
    public class NewUslugaViewModel : INotifyPropertyChanged
    {
        HotelContext db;
        NewUsluga win;
        public NewUslugaViewModel(HotelContext context, NewUsluga w)
        {
            win = w;
            db = context;
            Cl = new ObservableCollection<Client>(db.Clients);
            AD = new ObservableCollection<Additional_services>(db.Additional_services);
        }


        DateTime date;
        int quantity;
        decimal cost_service;
        bool payment;


        public DateTime Date
        {
            get { return date; }
            set
            {
                date = value;
                OnPropertyChanged("Date");
            }
        }

        public int Quantity
        {
            get { return quantity; }
            set
            {
                quantity = value;
                OnPropertyChanged("Quantity");
            }
        }
        public decimal Cost_service
        {
            get { return cost_service; }
            set
            {
                cost_service = value;
                OnPropertyChanged("Cost_service");
            }
        }
        public bool Payment
        {
            get { return payment; }
            set
            {
                payment = value;
                OnPropertyChanged("Payment");
            }
        }
        
        public ObservableCollection<Client> Cl { get; set; }
        Client selectCl;
        public Client SelectCl

        {
            get { return selectCl; }
            set
            {
                selectCl = value;
                OnPropertyChanged("SelectCl");
            }
        }

        public ObservableCollection<Additional_services> AD { get; set; }
        Additional_services selectAD;
        public Additional_services SelectAD

        {
            get { return selectAD; }
            set
            {
                selectAD = value;
                OnPropertyChanged("SelectAD");
            }
        }

        
        private RelayCommand addCommandNU;
        public RelayCommand AddCommandNU
        {
            get
            {
                return addCommandNU ??
                  (addCommandNU = new RelayCommand(obj =>
                  {
                      Service_check service_Check = new Service_check();
                      service_Check.id_check = 1;
                      service_Check.date = date;
                      service_Check.quantity = quantity;
                      service_Check.cost_service = cost_service;
                      service_Check.payment = payment;
                    
                      service_Check.id_client = selectCl.client_code;
                      service_Check.id_addition_services = selectAD.ID_additional_services;
                     

                      db.Service_check.Add(service_Check);
                      db.SaveChanges();

                      MessageBox.Show("Новый объект добавлен");
                  }));
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
