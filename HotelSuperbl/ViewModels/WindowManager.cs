using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HotelSuperbl.ViewModels
{

    public static class WindowManager
    {
        public static void CloseWindow(Guid id)
        {
            foreach (System.Windows.Window window in Application.Current.Windows)
            {
                var w_id = window.DataContext as IRequireViewIdentification;
                if (w_id != null && w_id.ViewID.Equals(id))
                {
                    window.Close();
                }
            }
        }
    }
}
