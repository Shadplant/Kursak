using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Catalog_Admin_GUI
{
    public class Admin_Gamelist_ViewModel : Base_Model
    {
        private Admin_Gamelist_Model model = new Admin_Gamelist_Model();
        private Game selectedgame;

        public Game SelectedGame
        {
            get { return selectedgame; }
            set { selectedgame = value; OnPropertyChanged("SelectedGame");}
        }

        public ObservableCollection<Game> Games { get; set; }

        public Admin_Gamelist_ViewModel()
        {
            Games = model.Get_Gamelist();
            SelectedGame = new Game();
        }
    }
}
