using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog_User_GUI
{
    public class Review : Base_Model
    {
        private int game_id;
        private int user_id;
        private string review_title;
        private string review_text;
        private int review_score;

        public int Game_ID
        {
            get { return game_id; }
            set
            {
                game_id = value;
                OnPropertyChanged("Game_ID");
            }
        }

        public int User_ID
        {
            get { return user_id; }
            set
            {
                user_id = value;
                OnPropertyChanged("User_ID");
            }
        }

        public string Review_Title
        {
            get { return review_title; }
            set
            {
                review_title = value;
                OnPropertyChanged("Review_Title");
            }
        }

        public string Review_Text
        {
            get { return review_text; }
            set
            {
                review_text = value;
                OnPropertyChanged("Review_Text");
            }
        }

        public int Review_Score
        {
            get { return review_score; }
            set
            {
                review_score = value;
                OnPropertyChanged("Review_Score");
            }
        }
    }
}
