using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Catalog_GUI
{
    public class Admin_Login_Model : Base_Model
    {
        public bool Check_Email_Model(string Email)
        {
            return ServiceSingleton.getInstance().getService().Check_Email(Email.ToLower());
        }

        public string Login_Admin_Model(string Email, string Password)
        {
            return ServiceSingleton.getInstance().getService().Login_Admin(Email.ToLower(), Password);
        }
    }
}
