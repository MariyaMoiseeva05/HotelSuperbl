
using HotelSuperbl.Helpers;
using HotelSuperbl.Models;
using HotelSuperbl.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HotelSuperbl.ViewModels
{

    public class ClientViewModel : INotifyPropertyChanged
    {

        private Client selectedClient;
        public ObservableCollection<Client> Clients { get; set; }
        public ClientViewModel()
        {
            Clients = new ObservableCollection<Client>();
        }
        public Client SelectedClient
        {
            get { return selectedClient; }
            set
            {
                selectedClient = value;
                OnPropertyChanged("SelectedClient");
            }
        }
        //команда удаления
        private RelayCommand removeCommandCl;
        public RelayCommand RemoveCommandCl
        {
            get
            {
                return removeCommandCl ??
                  (removeCommandCl = new RelayCommand(obj =>
                  {
                      Client client = obj as Client;
                      if (client != null)
                      {
                          Clients.Remove(client);
                      }
                  },

                 (obj) => (Clients.Count > 0 && selectedClient != null)));
            }
        }
        //команда добавления
      
        

        private Client client;

        public ClientViewModel(Client cl)
        {
            client = cl;
        }

        public int Client_code
        {
            get { return client.client_code; }
            set
            {
                client.client_code = value;
                OnPropertyChanged("Код клиента");
            }
        }
        public string Surname
        {
            get { return client.surname; }
            set
            {
                client.surname = value;
                OnPropertyChanged("Фамилия");
            }
        }
        public string Name
        {
            get { return client.name; }
            set
            {
                client.name = value;
                OnPropertyChanged("Имя");
            }
        }
        public string Patronymic
        {
            get { return client.patronymic; }
            set
            {
                client.patronymic = value;
                OnPropertyChanged("Отчество");
            }
        }
        public string Phone_number
        {
            get { return client.phone_number; }
            set
            {
                client.phone_number = value;
                OnPropertyChanged("Номер телефона");
            }
        }
        public string E_mail
        {
            get { return client.e_mail; }
            set
            {
                client.e_mail = value;
                OnPropertyChanged("e_mail");
            }
        }
        public string Citizenship
        {
            get { return client.citizenship; }
            set
            {
                client.citizenship = value;
                OnPropertyChanged("Гражданство");
            }
        }
        public string Passport_data
        {
            get { return client.pasport_data; }
            set
            {
                client.pasport_data = value;
                OnPropertyChanged("Паспортные данные");
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


