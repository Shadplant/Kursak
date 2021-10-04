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
        User_Login_ViewModel model;
        public User_Login_View()
        {
            InitializeComponent();
            DataContext = model =  new User_Login_ViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (model.Login_User_ViewModel())
            {
                //new Game_Add_View().Show();
                this.Close();
            }
        }
    }
}
