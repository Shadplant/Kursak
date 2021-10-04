using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Catalog_Admin_GUI
{
    public class Game_Add_Model : Base_Model
    {

        public void Add_Game_Model(string Game_Name, string Game_Description, string Game_Image_Link, int Publishing_Admin_ID)
        {
            ServiceSingleton.getInstance().getService().Add_Game(Game_Name, Game_Description, Game_Image_Link, Publishing_Admin_ID);
        }
    }
}
