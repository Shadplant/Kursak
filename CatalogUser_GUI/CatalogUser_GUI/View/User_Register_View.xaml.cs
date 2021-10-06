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
    /// Interaction logic for User_Register_View.xaml
    /// </summary>
    public partial class User_Register_View : Window
    {
        User_Register_ViewModel model = new User_Register_ViewModel();
        public User_Register_View()
        {
            InitializeComponent();
            DataContext = model;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //if (model.Register_User_ViewModel())
            //{
                new User_Main_View().Show();
                this.Close();
            //}
        }
    }
}
