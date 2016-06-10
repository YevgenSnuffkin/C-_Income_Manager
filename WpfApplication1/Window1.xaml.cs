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
using System.Data.SqlClient;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class myDesktop : Window
    {
              
        public myDesktop()
        {

            InitializeComponent();
                                   
        }
       
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        //window itself contains info about author and last change to income
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Income_ManagerEntities context = new Income_ManagerEntities();
            var users = context.Table_user.ToArray();
            foreach (var user in users)
            {
               // MessageBox.Show(user.rent.ToString());
            }
            DiagramWindow win1 = new DiagramWindow();
            win1.Show();         


            //should open diagram
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window3 wincalc = new Window3();

            wincalc.Show();

            //income and costs
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //exit
        }
       
    }
}
