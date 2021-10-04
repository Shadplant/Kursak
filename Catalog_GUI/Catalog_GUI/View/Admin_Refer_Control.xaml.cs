using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Catalog_Admin_GUI
{
    /// <summary>
    /// Interaction logic for Admin_Refer_Control.xaml
    /// </summary>
    public partial class Admin_Refer_Control : UserControl
    {
        public Admin_Refer_Control()
        {
            InitializeComponent();
            DataContext = new Admin_Refer_ViewModel();
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
    }
}
