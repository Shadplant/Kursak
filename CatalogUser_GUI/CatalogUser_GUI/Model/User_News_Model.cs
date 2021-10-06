using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog_User_GUI
{
    public class User_News_Model : Base_Model
    {
        public string Get_User_News_Model()
        {
            return ServiceSingleton.getInstance().getService().Get_News();
        }
    }
}
