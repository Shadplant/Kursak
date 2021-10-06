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
using System.Windows.Shapes;

namespace Catalog_User_GUI
{
    /// <summary>
    /// Interaction logic for User_Review_View.xaml
    /// </summary>
    public partial class User_Review_View : Window
    {
        User_Review_ViewModel model = new User_Review_ViewModel();
        public User_Review_View()
        {
            InitializeComponent();
            DataContext = model;
        }

        private void Accept_Button_Click(object sender, RoutedEventArgs e)
        {
            model.
        }

        private void Decline_Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
