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
using System.Data.Entity.Validation;
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
            Income_ManagerEntities context = new Income_ManagerEntities();
            if (context.Table_user.Count() == 0)
            {
                MessageBox.Show("no data!");
            }
            var usersadd = context.Table_user;

            var users = context.Table_user.ToArray();

            int sumOfRent =
                Convert.ToInt32(context.Table_user.Sum(user => user.rent));
            int sumOfFood=
                Convert.ToInt32(context.Table_user.Sum(user => user.food));
            int sumOfClothes=
                Convert.ToInt32(context.Table_user.Sum(user => user.clothes)); 
            int sumOfIncome=
                Convert.ToInt32(context.Table_user.Sum(user => user.income)); 
            
           
            
            ((BarSeries)wydatkiChart.Series[0]).ItemsSource = new KeyValuePair<string, int>[]{

                new KeyValuePair<string, int>("rent", sumOfRent),

                new KeyValuePair<string, int>("food", sumOfFood),

                new KeyValuePair<string, int>("clothes", sumOfClothes),

                new KeyValuePair<string, int>("income", sumOfIncome)};

            XMLexport expo = new XMLexport();

            expo.createXML(sumOfRent,sumOfFood,sumOfClothes,sumOfIncome);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            LoadBarChartData();

             
        }

       

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            using (var context = new Income_ManagerEntities())
            {
                var rowClean = context.Database.ExecuteSqlCommand("TRUNCATE TABLE [Table_user]");
                //rowClean.All<>;
            }   

        }
    }
}
