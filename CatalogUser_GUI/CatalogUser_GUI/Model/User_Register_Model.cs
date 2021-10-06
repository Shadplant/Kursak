using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog_User_GUI
{
    public class User_Register_Model : Base_Model
    {
        public int Register_User_Model(string Email, string Login, string Password)
        {
            return ServiceSingleton.getInstance().getService().Register_User(Email, Login, Password);
        }
    }
}
