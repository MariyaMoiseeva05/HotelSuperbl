using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSuperbl.Models
{
    public class ReportsModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public class Service_check
        {

            public DateTime date { get; set; }
            public int client_code { get; set; }
            public int id_check { get; set; }
            public string surname { get; set; }
            public string name { get; set; }
            public string patronymic { get; set; }
            public string nameServ { get; set; }
            public decimal current_price { get; set; }
            public int quantity { get; set; }
            public decimal sum { get; set; }

        }

        public class SpResult
        {
            public DateTime Дата_счёта { get; set; }
            public int Код_клиента { get; set; }
            public int Номер_счёта { get; set; }
            public string Фамилия_клиента { get; set; }
            public string Имя_клиента { get; set; }
            public string Отчество_клиента { get; set; }
            public string Название_услуги { get; set; }
            public decimal Цена { get; set; }
            public int Количество { get; set; }
            public decimal Сумма { get; set; }

        }

        public class Report
        {
           
            public int Категория_номера { get; set; }
            public string Номер_коттеджа { get; set; }
            public string Состояние { get; set; }

        }

    }
}
