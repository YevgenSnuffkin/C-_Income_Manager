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
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public string wholePay;
        public Window3()
        {
            InitializeComponent();
            tbox1.Clear();
        }
        

        private void Button_Click(object sender, RoutedEventArgs e)
            {
            
           ;
            
            Income_ManagerEntities context = new Income_ManagerEntities();
            var users = context.Table_user.ToArray();
            foreach (var user in users)
            {  
                 wholePay = wholePay + user.rent.ToString();

            }
            lbl1.Content = wholePay;
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

      
          
    }
}
