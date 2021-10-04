using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Catalog_Admin_GUI
{
    public class Admin_Refer_Model : Base_Model
    {
        public bool Check_Email_Model(string Email)
        {
            return ServiceSingleton.getInstance().getService().Check_Email(Email.ToLower());
        }

        public void Refer_Admin_Model(string Email, string Password)
        {
            ServiceSingleton.getInstance().getService().Refer_Admin(Email.ToLower(), Password);
        }
    }
}
