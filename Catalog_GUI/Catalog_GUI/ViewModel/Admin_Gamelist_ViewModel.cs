using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;

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

        private RelayCommand delete_command;
        public RelayCommand Delete_Command
        {
            get
            {
                return delete_command ?? (delete_command = new RelayCommand(obj => Delete_Game_ViewModel()));
            }
        }

        private RelayCommand edit_command;
        public RelayCommand Edit_Command
        {
            get
            {
                return edit_command ?? (edit_command = new RelayCommand(obj => Edit_Game_ViewModel()));
            }
        }

        public void Delete_Game_ViewModel()
        {
            try
            {
                if (SelectedGame.Game_ID > 0)
                {
                    model.Delete_Game(SelectedGame);
                    MessageBox.Show("Success");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Edit_Game_ViewModel()
        {
            try
            {
                if (SelectedGame.Game_ID > 0)
                {
                    model.Edit_Game(SelectedGame);
                    MessageBox.Show("Success");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
