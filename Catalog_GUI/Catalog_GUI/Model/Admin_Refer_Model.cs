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

        public List<string> Get_Admin_List(int ID)
        {
            return ServiceSingleton.getInstance().getService().Get_Admin_List(ID);
        }

        public void Refer_Admin_Model(int ID, string Email, string Password)
        {
            ServiceSingleton.getInstance().getService().Refer_Admin(ID, Email.ToLower(), Password);
        }
    }
}
