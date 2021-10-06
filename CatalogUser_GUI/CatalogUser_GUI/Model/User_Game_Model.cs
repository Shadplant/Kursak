using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog_User_GUI
{
    public class User_Game_Model : Base_Model
    {
        public string Get_Game_Model(int id)
        {
            return ServiceSingleton.getInstance().getService().Get_Game(id);
        }

        public string Get_User_Reviews_Model(int id)
        {
            return ServiceSingleton.getInstance().getService().Get_Reviews(id);
        }
    }
}
