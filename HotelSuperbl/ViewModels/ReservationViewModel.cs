using HotelSuperbl.Helpers;
using HotelSuperbl.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HotelSuperbl.ViewModels
{
    public class ReservationViewModel : INotifyPropertyChanged
    {
        

        HotelContext DbContext = new HotelContext();
        private Reservation selectedReservation;
        public ObservableCollection<Reservation> Reservations { get; set; }
        public ReservationViewModel()
        {
            Reservations = new ObservableCollection<Reservation>();
        }

        //ObservableCollection<Reservation> GetAllReservation { get; set; }
       

        public Reservation SelectedReservation
        {
            get { return selectedReservation; }
            set
            {
                selectedReservation = value;
                OnPropertyChanged("SelectedReservation");
            }
        }

        

        //команда удаления
        private RelayCommand removeCommandRes;
        public RelayCommand RemoveCommandRes
        {
            get
            {
                return removeCommandRes ??
                  (removeCommandRes = new RelayCommand(obj =>
                  {
                      Reservation reservation = obj as Reservation;
                      if (reservation != null)
                      {
                          Reservations.Remove(reservation);
                      }
                  },
                 
                 (obj) => (Reservations.Count > 0 && selectedReservation != null)));
            }
        }
        //команда добавления
        private RelayCommand addCommandRes;
        public RelayCommand AddCommandRes
        {
            get
            {
                return addCommandRes ??
                  (addCommandRes = new RelayCommand(obj =>
                  {
                      CreateReservation createReservation = new CreateReservation();
                      Reservations.Insert(0, reservation);
                      SelectedReservation = reservation;
                  }));
            }
        }
        //команда изменения
        private RelayCommand updateCommandRes;
        public RelayCommand UpdateCommandRes
        { get
            {
                return updateCommandRes ??
                    (updateCommandRes = new RelayCommand(obj =>
                    {
                        CreateReservation createReservation = new CreateReservation();
                      

                    }));
            } }
        private RelayCommand saveCommand;
        public RelayCommand SaveCommand
        {
            get
            {
                return saveCommand ??
                    (saveCommand = new RelayCommand(obj =>
                    {
                        Reservation reservation = obj as Reservation;
                        if (reservation != null)
                        {
                            DbContext.Reservations.Add(reservation);
                            DbContext.SaveChanges();
                        }
                    }));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        private Reservation reservation;
        

        public ReservationViewModel(Reservation rs)
        {
           reservation = rs;
        }

        public int Reservation_code
        {
            get { return reservation.reservation_code; }
            set
            {
                reservation.reservation_code = value;
                OnPropertyChanged("Код брони");
            }
        }
        public DateTime Date_reservation
        {
            get { return reservation.date_reservation; }
            set
            {
                reservation.date_reservation = value;
                OnPropertyChanged("Дата бронирования");
            }
        }

        public DateTime Arrival_dates
        {
            get { return reservation.arrival_dates; }
            set
            {
                reservation.arrival_dates = value;
                OnPropertyChanged("Дата заезда");
            }
        }

        public DateTime Dates_of_departure
        {
            get { return reservation.dates_of_departure; }
            set
            {
                reservation.dates_of_departure = value;
                OnPropertyChanged("Дата выезда");
            }
        }

        public int Client_code
        {
            get { return reservation.client_code; }
            set
            {
                reservation.client_code = value;
                OnPropertyChanged("Код клиента");
            }
        }

        public int ID_Room
        {
            get { return reservation.ID_room; }
            set
            {
                reservation.ID_room = value;
                OnPropertyChanged("Код коттеджа");
            }
        }

        public int ID_user
        {
            get { return reservation.Id_user; }
            set
            {
                reservation.Id_user = value;
                OnPropertyChanged("Код сотрудника");
            }
        }

        public int? Number_of_guests
        {
            get { return reservation.number_of_guests; }
            set
            {
                reservation.number_of_guests = value;
                OnPropertyChanged("Количество гостей");
            }
        }

        public string Status
        {
            get { return reservation.status; }
            set
            {
                reservation.status = value;
                OnPropertyChanged("Статус брони");
            }
        }

    }
}

