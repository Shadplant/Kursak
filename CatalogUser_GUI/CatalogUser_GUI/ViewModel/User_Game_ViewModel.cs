using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog_User_GUI
{
    public class User_Game_ViewModel : Base_Model
    {
        private User_Game_Model model = new User_Game_Model();
        private string name;
        private string description;
        private string game_link;
        private string image_link;
        private int rating;

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

        public string Game_Link
        {
            get { return game_link; }
            set
            {
                game_link = value;
                OnPropertyChanged("Game_Link");
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

        public int Rating
        {
            get { return rating; }
            set
            {
                rating = value;
                OnPropertyChanged("Rating");
            }
        }

        User_Game_ViewModel(int id)
        {
            
        }

        public void Refresh()
        {

        }
    }
}
