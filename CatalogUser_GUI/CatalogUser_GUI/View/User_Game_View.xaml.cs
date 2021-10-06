﻿using System;
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
    /// Interaction logic for User_Game_View.xaml
    /// </summary>
    public partial class User_Game_View : Window
    {
        User_Game_ViewModel model = new User_Game_ViewModel();
        public User_Game_View()
        {
            InitializeComponent();
            DataContext = model;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new User_Review_View().ShowDialog();
            model.Refresh();
        }
    }
}
