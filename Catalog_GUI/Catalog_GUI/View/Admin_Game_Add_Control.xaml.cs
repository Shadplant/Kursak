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
    /// Interaction logic for Admin_Add_Control.xaml
    /// </summary>
    public partial class Admin_Game_Add_Control : UserControl
    {
        public Admin_Game_Add_Control()
        {
            InitializeComponent();
            DataContext = new Game_Add_ViewModel();
        }
    }
}
