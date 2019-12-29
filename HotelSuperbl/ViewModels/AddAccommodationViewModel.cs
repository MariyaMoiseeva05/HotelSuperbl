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

    public class AddAccommodationViewModel : INotifyPropertyChanged
    {


        AddAccommodationView aa;
        HotelContext db = new HotelContext();

        
        public ObservableCollection<Accommodation> Accommodations { get; set; }

        public AddAccommodationViewModel()
        {
            Accommodations = new ObservableCollection<Accommodation>();
        }



        public AddAccommodationViewModel(HotelContext context, AddAccommodationView Aa)
        {
            aa = Aa;
            db = context;
            Res= new ObservableCollection<Reservation>(db.Reservations);
          

        }

        DateTime date_cost;
        decimal cost_accomodation;
        public DateTime Date_cost
        {
            get { return date_cost; }
            set
            {
                date_cost = value;
                OnPropertyChanged("Date_cost");
            }
        }

        public decimal Cost_accomodation
        {
            get { return cost_accomodation; }
            set
            {
                cost_accomodation = value;
                OnPropertyChanged("Cost_accomodation");
            }
        }

       

     

        public ObservableCollection<Reservation> Res { get; set; }
        Reservation selectRes;
        public Reservation SelectRes

        {
            get { return selectRes; }
            set
            {
                selectRes = value;
                OnPropertyChanged("SelectRes");
            }
        }

      


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }




        private RelayCommand addCommandAC;
        public RelayCommand AddCommandAC
        {
            get
            {
                return addCommandAC ??
                  (addCommandAC = new RelayCommand(obj =>
                  {

                      int n = 6;
                      Accommodation accommodation = new Accommodation();
                      accommodation.ID_cost = n + 1;
                      accommodation.date_cost = Date_cost;
                      accommodation.cost_accomodation = Cost_accomodation;

                      accommodation.reservation_code = selectRes.reservation_code;

                      db.Accommodations.Add(accommodation);
                      db.SaveChanges();
                      MessageBox.Show("Новый объект добавлен");

                  }));
            }
        }


    }

}


