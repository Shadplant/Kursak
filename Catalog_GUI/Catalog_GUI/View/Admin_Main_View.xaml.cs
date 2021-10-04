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

namespace Catalog_Admin_GUI
{
    /// <summary>
    /// Interaction logic for Admin_Main_View.xaml
    /// </summary>
    public partial class Admin_Main_View : Window
    {
        public Admin_Main_View()
        {
            InitializeComponent();
            Window_Control_Grid.Children.Add(new Admin_Gamelist_Control());
        }

        private void Exit_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Logout_Button_Click(object sender, RoutedEventArgs e)
        {
            new Admin_Login_View().Show();
            this.Close();
        }

        private void Switch_View(object sender, RoutedEventArgs e)
        {
            var choice = sender as RadioButton;
            Window_Control_Grid.Children.Clear();
            switch (choice.Name)
            {
                case ("Gamelist_Button"):
                    Window_Control_Grid.Children.Add(new Admin_Gamelist_Control());
                    GC.Collect();
                    break;
                case ("Add_Item_Button"):
                    Window_Control_Grid.Children.Add(new Admin_Game_Add_Control());
                    GC.Collect();
                    break;
                case ("Referal_Button"):
                    Window_Control_Grid.Children.Add(new Admin_Refer_Control());
                    GC.Collect();
                    break;
                default:
                    break;
            }
        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            this.DragMove();
        }

    }

}
