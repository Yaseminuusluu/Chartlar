using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
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

namespace Chartlar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SeriesCollection = new SeriesCollection
            {

                new PieSeries
                {
                    Title="t1",
                    Values = new ChartValues<ObservableValue>{new ObservableValue(10)},
                    DataLabels= true
                },
                 new PieSeries
                {
                    Title="t2",
                    Values = new ChartValues<ObservableValue>{new ObservableValue(20)},
                    DataLabels= true
                },
                   new PieSeries
                {
                    Title="t3",
                    Values = new ChartValues<ObservableValue>{new ObservableValue(27)},
                    DataLabels= true
                },
                       new PieSeries
                {
                    Title="t4",
                    Values = new ChartValues<ObservableValue>{new ObservableValue(33)},
                    DataLabels= true
                }
            };
            DataContext = this;
        }
        public SeriesCollection SeriesCollection{get; set;}

        private void PieChart_DataClick(object sender,ChartPoint chartPoint)
        {
            MessageBox.Show("Current value:"+chartPoint.Y+"("+(chartPoint.Participation *100).ToString()+"%)");
        }
    }
}
