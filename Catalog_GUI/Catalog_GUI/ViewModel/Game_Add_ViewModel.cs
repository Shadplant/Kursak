using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Catalog_Admin_GUI
{
    public class Game_Add_ViewModel : INotifyPropertyChanged
    {
        Game_Add_Model model = new Game_Add_Model();
        private string name;
        private string description;
        private string image_link;
        private string game_link;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        public string Description
        {
            get { return description; }
            set
            {
                description = value;
                OnPropertyChanged("Description");
            }
        }

        public string Image_Link
        {
            get { return image_link; }
            set
            {
                image_link = value;
                OnPropertyChanged("Image_Link");
            }
        }

        public string Game_Link
        {
            get { return game_link; }
            set
            {
                game_link = value;
                OnPropertyChanged("Game_Link");
            }
        }

        private RelayCommand add_game_command;
        public RelayCommand Add_Game_Command
        {
            get
            {
                return add_game_command ?? (add_game_command = new RelayCommand(obj => Add_Game_ViewModel()));
            }
        }

        public void Add_Game_ViewModel()
        {
            try
            {
                model.Add_Game_Model(name, description, image_link, game_link);
                MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
