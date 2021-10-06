using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Catalog_User_GUI
{
    public class User_Gamelist_Model : Base_Model
    {
        public ObservableCollection<Game> Get_Gamelist()
        {
            return JsonConvert.DeserializeObject<ObservableCollection<Game>>(ServiceSingleton.getInstance().getService().Get_Games());
        }
    }
}
