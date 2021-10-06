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

namespace Catalog_User_GUI
{
    /// <summary>
    /// Interaction logic for Admin_Login_View.xaml
    /// </summary>
    public partial class User_Login_View : Window
    {
        User_Login_ViewModel model = new User_Login_ViewModel();
        public User_Login_View()
        {
            InitializeComponent();
            DataContext = model;
        }

        private void Show_Pass_Button_Checked(object sender, RoutedEventArgs e)
        {
            Password_Box.Visibility = Visibility.Hidden;
            Password_Box_Revealed.Visibility = Visibility.Visible;
            Password_Box_Revealed.Text = Password_Box.Password;
        }
        private void Show_Pass_Button_Unchecked(object sender, RoutedEventArgs e)
        {
            Password_Box.Visibility = Visibility.Visible;
            Password_Box_Revealed.Visibility = Visibility.Hidden;
            Password_Box.Password = Password_Box_Revealed.Text;
        }


        private void Login_Button_Click(object sender, RoutedEventArgs e)
        {
            if (Password_Box.Visibility == Visibility.Visible)
            {
                Password_Box_Revealed.Text = Password_Box.Password;
                model.Password = Password_Box.Password;
            }
            else
            {
                Password_Box.Password = Password_Box_Revealed.Text;
                model.Password = Password_Box.Password;
            }

            if (model.Login_User_ViewModel())
            {
                new User_Main_View().Show();
                this.Close();
            }
        }
    }
}
