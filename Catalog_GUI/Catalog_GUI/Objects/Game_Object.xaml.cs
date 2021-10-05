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
    /// Interaction logic for Game_Object.xaml
    /// </summary>
    public partial class Game_Object : UserControl
    {
        public Game_Object()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty GameProperty =
            DependencyProperty.Register(
                "Game_Ref",
                typeof(Game),
                typeof(Game_Object),
                new PropertyMetadata(null));

        public Game Game_Ref
        {
            get
            {
                return (Game)GetValue(GameProperty);
            }
            set
            {
                SetValue(GameProperty, value);
            }
        }
    }
}
