using HotelSuperbl.Helpers;
using HotelSuperbl.Models;
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
    public class CreateReservationViewModel : INotifyPropertyChanged
    {

    CreateReservation cres;
    HotelContext db = new HotelContext();
    private CreateReservation selectedCreateReservation;
    public ObservableCollection<Reservation> Reservations { get; set; }

    public CreateReservationViewModel()
    {
        Reservations = new ObservableCollection<Reservation>();
    }
        
       
        public CreateReservationViewModel(HotelContext context, CreateReservation cr)
        {
            cres = cr;
            db = context;
            Id_user = new ObservableCollection<User>(db.Users);
            Cl = new ObservableCollection<Client>(db.Clients);
            ID_room = new ObservableCollection<Hotel_room>(db.Hotel_room);
           
        }




        DateTime date_reservation;
        DateTime arrival_dates;
        DateTime dates_of_departure;
    int number_of_guests;
    string status;



    public DateTime Date_reservation
    {
        get { return date_reservation; }
        set
        {
                date_reservation = value;
            OnPropertyChanged("Date_reservation");
        }
    }

    public DateTime Arrival_dates
        {
        get { return arrival_dates; }
        set
        {
                arrival_dates = value;
            OnPropertyChanged("Arrival_dates");
        }
    }

    public DateTime Dates_of_departure
        {
        get { return dates_of_departure; }
        set
        {
                dates_of_departure = value;
            OnPropertyChanged("Dates_of_departure");
        }
    }

    public int Number_of_guests
        {
        get { return number_of_guests; }
        set
        {
                number_of_guests = value;
            OnPropertyChanged("Number_of_guests");
        }
    }

    public string Status
        {
        get { return status; }
        set
        {
            status = value;
            OnPropertyChanged("Status");
        }
    }

        public ObservableCollection<User> Id_user { get; set; }
        User selectUser;
        public User SelectUser

        {
            get { return selectUser; }
            set
            {
                selectUser = value;
                OnPropertyChanged("SelectUser");
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

        public ObservableCollection<Hotel_room> ID_room { get; set; }
        Hotel_room selectHotel_room;
        public Hotel_room SelectHotel_room

        {
            get { return selectHotel_room; }
            set
            {
                selectHotel_room = value;
                OnPropertyChanged("SelectHotel_room");
            }
        }

        public CreateReservation SelectedCreateReservation
        {
            get { return selectedCreateReservation; }
            set
            {
                selectedCreateReservation = value;
                OnPropertyChanged("selectedCreateReservation");
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;
    public void OnPropertyChanged([CallerMemberName]string prop = "")
    {
        if (PropertyChanged != null)
            PropertyChanged(this, new PropertyChangedEventArgs(prop));
    }




    private RelayCommand addCommandCR;
    public RelayCommand AddCommandCR
    {
        get
        {
            return addCommandCR ??
              (addCommandCR = new RelayCommand(obj =>
              {

                  Reservation reservation = new Reservation();
                  reservation.reservation_code = 1;
                  reservation.date_reservation = date_reservation;
                  reservation.arrival_dates = arrival_dates;
                  reservation.dates_of_departure = dates_of_departure;
                  reservation.number_of_guests = number_of_guests;
                  reservation.status = status;

                  reservation.Id_user = selectUser.ID_user;
                  reservation.ID_room = selectHotel_room.ID_room;
                  reservation.client_code = selectCl.client_code;
                  
                  db.Reservations.Add(reservation);
                  db.SaveChanges();
                  MessageBox.Show("Новый объект добавлен");

              }));
        }
    }


}

}


