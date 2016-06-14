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
        public int sumOfRent;
        public int sumOfFood;
        public int sumOfClothes;
        public int sumOfIncome;

        public DiagramWindow()
        {
            InitializeComponent();
            LoadBarChartData();
        }
        private void LoadBarChartData()
        {
            Income_ManagerEntities context = new Income_ManagerEntities();
            var usersadd = context.Table_user;
            var users = context.Table_user.ToArray();
            /*var t = new Table_user 
            {
                username = "new1",
                rent= 10,
                food=  20,
                clothes = 30,
                income =100
            };

            usersadd.Add(t);
            try
            {
                context.SaveChanges(); 
            }
            catch (DbEntityValidationException e)
            {
                var errors = e.EntityValidationErrors;

            }*/
            
            foreach (var user in users)
            {

                sumOfRent = sumOfRent +  Convert.ToInt32(user.rent);
                sumOfFood = sumOfFood + Convert.ToInt32(user.food);
                sumOfClothes = sumOfClothes + Convert.ToInt32(user.clothes);
                sumOfIncome = sumOfIncome + Convert.ToInt32(user.income);
            }
            
            ((BarSeries)wydatkiChart.Series[0]).ItemsSource =
              new KeyValuePair<string, int>[]{
            new KeyValuePair<string, int>("rent", sumOfRent),
            new KeyValuePair<string, int>("food", sumOfFood),
            new KeyValuePair<string, int>("clothes", sumOfClothes),
            new KeyValuePair<string, int>("income", sumOfIncome)};
           
        }
    }
}
