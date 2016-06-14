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
using System.Data.Entity.Validation;

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
            
        }
      
        private void Button_Click(object sender, RoutedEventArgs e)
            {
                //tboxRent.Text = "";
                Income_ManagerEntities context = new Income_ManagerEntities();
                var usersadd = context.Table_user;
                var users = context.Table_user.ToArray();
                var t = new Table_user
                {
                    username = "new1",
                    rent = decimal.Parse(tboxRent.Text),
                    food = decimal.Parse(tboxFood.Text),
                    clothes = decimal.Parse(tboxClothes.Text),
                    income = decimal.Parse(tboxIncome.Text)
                };
                usersadd.Add(t);
                try
                {
                    context.SaveChanges();
                }
                catch (DbEntityValidationException b)
                {
                    var errors = b.EntityValidationErrors;
                }
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        { 
            
        }

        public void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
           
            TextBox txtBox = sender as TextBox;
            txtBox.Text = string.Empty;
            
        }
    }
}
