using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Catalog_User_GUI
{
    public class Game : Base_Model
    {
        private int game_id;
        private string game_name;
        private string game_image_link;
        private string game_description;
        private string game_link;
        private int rating;

        public int Game_ID
        {
            get { return game_id; }
            set
            {
                game_id = value;
                OnPropertyChanged("Game_ID");
            }
        }

        public string Game_Name
        {
            get { return game_name; }
            set
            {
                game_name = value;
                OnPropertyChanged("Game_Name");
            }
        }

        public string Game_Image_Link
        {
            get { return game_image_link; }
            set
            {
                game_image_link = value;
                OnPropertyChanged("Game_Image_Link");
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

        public int Rating
        {
            get { return rating; }
            set
            {
                rating = value;
                OnPropertyChanged("Rating");
            }
        }

        public string Game_Description
        {
            get { return game_description; }
            set
            {
                game_description = value;
                OnPropertyChanged("Game_Description");
            }
        }
    }
}
