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
    public class Room_categoryViewModel : INotifyPropertyChanged
    {

        private Room_category selectedRoom_category;
        public ObservableCollection<Room_category> Room_category { get; set; }
        public Room_categoryViewModel()
        {
            Room_category = new ObservableCollection<Room_category>();
        }
        public Room_category SelectedRoom_category
        {
            get { return selectedRoom_category; }
            set
            {
                selectedRoom_category = value;
                OnPropertyChanged("SelectedRoom_category");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        private Room_category room_category;

        public Room_categoryViewModel(Room_category rc)
        {
            room_category = rc;
        }

        public int ID_category
        {
            get { return room_category.ID_category; }
            set
            {
                room_category.ID_category = value;
                OnPropertyChanged("Код категории");
            }
        }
        public string Name
        {
            get { return room_category.name; }
            set
            {
                room_category.name = value;
                OnPropertyChanged("Название");
            }
        }

        public int Number_of_rooms
        {
            get { return room_category.number_of_rooms; }
            set
            {
                room_category.number_of_rooms = value;
                OnPropertyChanged("Количество комнат");
            }
        }

        public int Number_of_beds
        {
            get { return room_category.number_of_beds; }
            set
            {
                room_category.number_of_beds = value;
                OnPropertyChanged("Количетство спальных мест");
            }
        }

        public string Equipment
        {
            get { return room_category.equipment; }
            set
            {
                room_category.equipment = value;
                OnPropertyChanged("Оснащение");
            }
        }

        public decimal Cost
        {
            get { return room_category.cost; }
            set
            {
                room_category.cost = value;
                OnPropertyChanged("Стоимость");
            }
        }

        


    }
}

