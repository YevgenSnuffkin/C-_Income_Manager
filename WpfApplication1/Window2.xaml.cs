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
using System.Windows.Shapes;
using PieControls;
using System.Windows.Controls.DataVisualization;
using System.Windows.Controls.DataVisualization.Charting;
namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class DiagramWindow : Window
    {
        
        public DiagramWindow()
        {
            InitializeComponent();
            LoadBarChartData();
        }
        private void LoadBarChartData()
        {
          ((BarSeries)mcChart.Series[0]).ItemsSource =
            new KeyValuePair<string, int>[]{
            new KeyValuePair<string, int>("Project Manager", 12),
            new KeyValuePair<string, int>("CEO", 25),
            new KeyValuePair<string, int>("Software Engg.", 5),
            new KeyValuePair<string, int>("Team Leader", 6),
            new KeyValuePair<string, int>("Project Leader", 10),
            new KeyValuePair<string, int>("Developer", 4) };
        }
    }
}
