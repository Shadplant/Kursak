using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog_User_GUI
{
    public class User_Review_Model : Base_Model
    {
        public void Set_Review_User_Model(string serialized_review)
        {
            ServiceSingleton.getInstance().getService().Review_User(serialized_review);
        }
    }
}
