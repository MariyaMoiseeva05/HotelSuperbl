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

namespace HotelSuperbl.ViewModels
{

    public class Hotel_roomViewModel : INotifyPropertyChanged
    {
     

        private Hotel_room selectedHotel_room;
        public ObservableCollection<Hotel_room> Hotel_room { get; set; }

        public Hotel_roomViewModel()
        {
            Hotel_room = new ObservableCollection<Hotel_room>();
        }
        public Hotel_room SelectedHotel_room
        {
            get { return selectedHotel_room; }
            set
            {
                selectedHotel_room = value;
                OnPropertyChanged("SelectedHotel_room");
            }
        }



//команда удаления
private RelayCommand removeCommandHr;
        public RelayCommand RemoveCommandHr
        {
            get
            {
                return removeCommandHr ??
                  (removeCommandHr = new RelayCommand(obj =>
                  {
                      Hotel_room client = obj as Hotel_room;
                      if (hotel_room != null)
                      {
                          Hotel_room.Remove(hotel_room);
                      }
                  },

                 (obj) => (Hotel_room.Count > 0 && selectedHotel_room != null)));
            }
        }
       

        private Hotel_room hotel_room;

        public Hotel_roomViewModel(Hotel_room hr)
        {
            hotel_room = hr;
        }

        public int ID_room
        {
            get { return hotel_room.ID_room; }
            set
            {
                hotel_room.ID_room = value;
                OnPropertyChanged("Код коттеджа");
            }
        }
        public int Room_number
        {
            get { return hotel_room.room_number; }
            set
            {
                hotel_room.room_number = value;
                OnPropertyChanged("Номер коттеджа");
            }
        }
        public int ID_category
        {
            get { return hotel_room.ID_category; }
            set
            {
                hotel_room.ID_category = value;
                OnPropertyChanged("Код категории");
            }
        }
        public string Condition
        {
            get { return hotel_room.condition; }
            set
            {
                hotel_room.condition = value;
                OnPropertyChanged("Состояние коттеджа");
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




