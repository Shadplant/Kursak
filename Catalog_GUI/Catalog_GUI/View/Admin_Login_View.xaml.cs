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

namespace Catalog_Admin_GUI
{
    /// <summary>
    /// Interaction logic for Admin_Login_View.xaml
    /// </summary>
    public partial class Admin_Login_View : Window
    {
        Admin_Login_ViewModel model = new Admin_Login_ViewModel();
        public Admin_Login_View()
        {
            InitializeComponent();
            DataContext = model;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (model.Login_Admin_ViewModel())
            {
                new Admin_Main_View().Show();
                this.Close();
            }
        }
    }
}
