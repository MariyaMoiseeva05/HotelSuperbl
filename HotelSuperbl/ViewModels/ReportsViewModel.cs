using HotelSuperbl.Helpers;
using HotelSuperbl.Models;
using HotelSuperbl.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static HotelSuperbl.Models.ReportsModel;

namespace HotelSuperbl.ViewModels
{
    public class ReportsViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        private HotelContext db;
        private class SPResult
    {
        public string Customer { get; set; }
        public string PhoneName { get; set; }
        public DateTime Date { get; set; }
    }
    public ReportsViewModel(HotelContext dbcontext)
    {
        this.db = dbcontext;
    }

    //выполнить ХП
    public static List<SpResult> ExecuteSP(DateTime date, int client_code)
    {

        System.Data.SqlClient.SqlParameter param1 = new System.Data.SqlClient.SqlParameter("@date", date); //дата
        System.Data.SqlClient.SqlParameter param2 = new System.Data.SqlClient.SqlParameter("@client_code", client_code); //клиент

        try
        {
            HotelContext db = new HotelContext();
            var result = db.Database.SqlQuery<SpResult>("Additional @date, @client_code", new object[] { param1, param2 }).ToList();
            return result;
        }
        catch
        {
            Console.WriteLine("Что-то не так. Попробуйте снова.");
            return null;
        };
    }
       /* public List<Report> ReportUpr (DateTime date, int client_code)
        {

            System.Data.SqlClient.SqlParameter param1 = new System.Data.SqlClient.SqlParameter("@date", date); //дата
            System.Data.SqlClient.SqlParameter param2 = new System.Data.SqlClient.SqlParameter("@client_code", client_code); //клиент

            try
            {
                HotelContext db = new HotelContext();
                var result = db.Database.SqlQuery<SpResult>("Additional @date, @client_code", new object[] { param1, param2 }).ToList();
                return result;
            }
            catch
            {
                Console.WriteLine("Что-то не так. Попробуйте снова.");
                return null;
            };
        }*/




        private RelayCommand reportService_check;
        public RelayCommand ReportService_check
        {
            get
            {
                return reportService_check ??
                  (reportService_check = new RelayCommand(obj =>
                  {
                      SearchService_check searchService_Check = new SearchService_check();
                     
                  }));
            }
        }
    }
}
