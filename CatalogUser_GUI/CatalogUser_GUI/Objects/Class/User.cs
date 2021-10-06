using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Catalog_User_GUI
{
    public class User : Base_Model
    {
        private int user_id;
        private string email;
        private string login;
        private string password;

        public int User_ID
        {
            get { return user_id; }
            set
            {
                user_id = value;
                OnPropertyChanged("User_ID");
            }
        }


        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                OnPropertyChanged("Email");
            }
        }

        public string Login
        {
            get { return login; }
            set
            {
                login = value;
                OnPropertyChanged("Login");
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged("Password");
            }
        }
    }
}
