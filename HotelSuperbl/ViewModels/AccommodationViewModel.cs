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
    public class AccommodationViewModel : INotifyPropertyChanged
    {

        private Accommodation selectedAccommodation;
        public ObservableCollection<Accommodation> Accommodations { get; set; }

        public AccommodationViewModel()
        {
            Accommodations = new ObservableCollection<Accommodation>();
        }
        public Accommodation SelectedAccommodation
        {
            get { return selectedAccommodation; }
            set
            {
                selectedAccommodation = value;
                OnPropertyChanged("SelectedAccommodation");
            }
        }
        //команда удаления
        private RelayCommand removeCommandAc;
        public RelayCommand RemoveCommandAc
        {
            get
            {
                return removeCommandAc ??
                  (removeCommandAc = new RelayCommand(obj =>
                  {
                      Accommodation accommodation = obj as Accommodation;
                      if (accommodation != null)
                      {
                          Accommodations.Remove(accommodation);
                      }
                  },

                 (obj) => (Accommodations.Count > 0 && selectedAccommodation != null)));
            }
        }
        //команда добавления
        private RelayCommand addCommandAc;
        public RelayCommand AddCommandAc
        {
            get
            {
                return addCommandAc ??
                  (addCommandAc = new RelayCommand(obj =>
                  {
                      AccommodationView createAccommodation = new AccommodationView();
                      Accommodations.Insert(0, accommodation);
                      SelectedAccommodation = accommodation;
                  }));
            }
        }
        //команда изменения
        private RelayCommand updateCommandRes;
        public RelayCommand UpdateCommandRes
        {
            get
            {
                return updateCommandRes ??
                    (updateCommandRes = new RelayCommand(obj =>
                    {
                        AccommodationView updateAccommodation = new AccommodationView();


                    }));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        private Accommodation accommodation;

        public AccommodationViewModel(Accommodation ac)
        {
            accommodation = ac;
        }

        public int ID_cost
        {
            get { return accommodation.ID_cost; }
            set
            {
                accommodation.ID_cost = value;
                OnPropertyChanged("Код платежа");
            }
        }
        public DateTime Date_cost
        {
            get { return accommodation.date_cost; }
            set
            {
                accommodation.date_cost = value;
                OnPropertyChanged("Дата платежа");
            }
        }

        public int Reservation_code
        {
            get { return accommodation.reservation_code; }
            set
            {
                accommodation.reservation_code = value;
                OnPropertyChanged("Код брони");
            }
        }

        public decimal cost_accomodation
        {
            get { return accommodation.cost_accomodation; }
            set
            {
                accommodation.cost_accomodation = value;
                OnPropertyChanged("Стоимость проживания");
            }

        }
    }
}



