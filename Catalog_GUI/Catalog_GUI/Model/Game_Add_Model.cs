using Newtonsoft.Json;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Catalog_Admin_GUI
{
    public class Game_Add_Model : Base_Model
    {

        public void Add_Game_Model(string Name, string Description, string Image_Link, string Link)
        {
            ServiceSingleton.getInstance().getService().Add_Game(JsonConvert.SerializeObject(new Game() { Game_Name = Name, Game_Description = Description, Game_Image_Link = Image_Link, Game_Link = Link }));
        }
    }
}
