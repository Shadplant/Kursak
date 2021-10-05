using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Catalog_Admin_GUI
{
    public class Admin_Gamelist_Model : Base_Model
    {
        public ObservableCollection<Game> Get_Gamelist()
        {
            return JsonConvert.DeserializeObject<ObservableCollection<Game>>(ServiceSingleton.getInstance().getService().Get_Games());
        }

        public void Edit_Game(Game game)
        {
            ServiceSingleton.getInstance().getService().Edit_Game(JsonConvert.SerializeObject(game));
        }

        public void Delete_Game(Game game)
        {
            ServiceSingleton.getInstance().getService().Delete_Game(game.Game_ID);
        }
    }
}
