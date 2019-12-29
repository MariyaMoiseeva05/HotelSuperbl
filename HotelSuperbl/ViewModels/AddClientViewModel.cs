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
    public class AddClientViewModel : INotifyPropertyChanged
    {
       

        AddClient adcl;
        HotelContext db = new HotelContext();
        private AddClient selectedAddClient;
        public ObservableCollection<Client> Clients { get; set; }
        public AddClientViewModel()
        {
            Clients = new ObservableCollection<Client>();
        }

       

        string surname;
        string name;
        string patronymic;
        string phone_number;
        string e_mail;
        string citizenship;
        string pasport_data;

    

        public string Surname
        {
            get { return surname; }
            set
            {
                surname = value;
                OnPropertyChanged("Surname");
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        public string Patronymic
        {
            get { return patronymic; }
            set
            {
                patronymic = value;
                OnPropertyChanged("Patronymic");
            }
        }

        public string Phone_number
        {
            get { return phone_number; }
            set
            {
                phone_number = value;
                OnPropertyChanged("Phone_number");
            }
        }

        public string E_mail
        {
            get { return e_mail; }
            set
            {
                e_mail = value;
                OnPropertyChanged("E_mail");
            }
        }

        public string Citizenship
        {
            get { return citizenship; }
            set
            {
                citizenship = value;
                OnPropertyChanged("Citizenship");
            }
        }

        public string Pasport_data
        {
            get { return pasport_data; }
            set
            {
                pasport_data = value;
                OnPropertyChanged("Pasport_data");
            }
        }


        public AddClient SelectedAddClient
        {
            get { return selectedAddClient; }
            set
            {
                selectedAddClient = value;
                OnPropertyChanged("SelectedAddClient");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

       


        private RelayCommand addCommandNC;
        public RelayCommand AddCommandNC
        {
            get
            {
                return addCommandNC ??
                  (addCommandNC = new RelayCommand(obj =>
                  {

                      int n = 11;
                      Client client = new Client();
                      client.client_code = n+1;
                      client.surname = surname; 
                      client.name = name;
                      client.patronymic = patronymic;
                      client.phone_number = phone_number;
                      client.e_mail = e_mail;
                      client.citizenship = citizenship;
                      client.pasport_data = pasport_data;


                      db.Clients.Add(client);
                      db.SaveChanges();
                      MessageBox.Show("Новый объект добавлен");

                  }));
            }
        }

       
    }

}
