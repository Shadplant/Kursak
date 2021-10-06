using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog_User_GUI
{
    public class User_Profile_Model : Base_Model 
    {
        public string Get_User_Profile_Model(int id)
        {
            return ServiceSingleton.getInstance().getService().Get_Profile(id);
        }
    }
}
