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

namespace Catalog_User_GUI
{
    /// <summary>
    /// Interaction logic for User_Gamelist_Control.xaml
    /// </summary>
    public partial class User_Gamelist_Control : UserControl
    {
        public User_Gamelist_Control()
        {
            InitializeComponent();
            DataContext = new User_Gamelist_ViewModel();
        }
    }
}
