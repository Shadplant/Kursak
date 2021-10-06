using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Catalog_User_GUI
{
    public class User_Login_Model : Base_Model
    {
        public bool Check_Login_Model(string Login)
        {
            return ServiceSingleton.getInstance().getService().Check_Login(Login);
        }

        public int Login_User_Model(string Login, string Password)
        {
            return ServiceSingleton.getInstance().getService().Login_User(Login, Password);
        }
    }
}
