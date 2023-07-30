using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Chartlar
{
    /// <summary>
    /// Interaction logic for Deneme.xaml
    /// </summary>
    public partial class Deneme : Window
    {
        public Deneme()
        {
            InitializeComponent();
            SeriesCollection = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title ="val1",
                    Values = new  ChartValues<double>{5,10,15,20}
                }
            };

            SeriesCollection.Add(new ColumnSeries
            {
                Title = "val2",
                Values = new ChartValues<double>{10,15,20,25}
            });

            BarLabels = new[] { "values 1","values 2","values 3", "values 4" };
            Formatter = value=>value.ToString();
            DataContext = this;
        }

        public SeriesCollection SeriesCollection { get; set; }
        public string [] BarLabels { get; set; }

        public Func<double,string> Formatter { get; set; }
    }
}
