using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HotelSuperbl
{
    /// <summary>
    ///
    /// </summary>
    public partial class Glavnoe : Page
    {
        public Glavnoe()
        {
            InitializeComponent();
        }
      
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            

            int index = int.Parse(((Button)e.Source).Uid);

            GradientStopCollection gsc = new GradientStopCollection();
            gsc.Add(new GradientStop()
            {
                Color = Colors.LightSkyBlue,
                Offset = 1
            });
            gsc.Add(new GradientStop()
            {
                Color = Colors.OldLace,
                Offset = 0
            });

            GridCursor.Margin = new Thickness(10 + (200 * index), 0, 0, 0);

            switch (index)
            {
                case 0:
                    GridMain.Background = new LinearGradientBrush(gsc, 0)
                    {
                        StartPoint = new Point(0.5, 0),
                        EndPoint = new Point(0.5, 1)
                    };
                    break;
                case 1:
                    GridMain.Background = new LinearGradientBrush(gsc, 0)
                    {
                        StartPoint = new Point(0.5, 0),
                        EndPoint = new Point(0.5, 1)
                    };
                    break;
                case 2:
                    GridMain.Background = new LinearGradientBrush(gsc, 0)
                    {
                        StartPoint = new Point(0.5, 0),
                        EndPoint = new Point(0.5, 1)
                    };
                    break;
                case 3:
                    GridMain.Background = new LinearGradientBrush(gsc, 0)
                    {
                        StartPoint = new Point(0.5, 0),
                        EndPoint = new Point(0.5, 1)
                    };
                    break;
                case 4:
                    GridMain.Background = new LinearGradientBrush(gsc, 0)
                    {
                        StartPoint = new Point(0.5, 0),
                        EndPoint = new Point(0.5, 1)
                    };
                    break;
                case 5:
                    GridMain.Background = new LinearGradientBrush(gsc, 0)
                    {
                        StartPoint = new Point(0.5, 0),
                        EndPoint = new Point(0.5, 1)
                    };
                    break;


            }
          
           

        }
    }
}

