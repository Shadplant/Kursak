
namespace DataBase_Logic
{
    public class Game
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
            set { game_id = value; }
        }

        public string Game_Name
        {
            get { return game_name; }
            set { game_name = value; }
        }

        public string Game_Image_Link
        {
            get { return game_image_link; }
            set { game_image_link = value; }
        }

        public string Game_Link
        {
            get { return game_link; }
            set { game_link = value; }
        }

        public int Rating
        {
            get { return rating; }
            set { rating = value; }
        }

        public string Game_Description
        {
            get { return game_description; }
            set { game_description = value; }
        }
    }
}