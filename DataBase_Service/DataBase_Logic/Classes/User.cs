﻿namespace DataBase_Logic
{
    public class User
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
            }
        }


        public string Email
        {
            get { return email; }
            set
            {
                email = value;
            }
        }

        public string Login
        {
            get { return login; }
            set
            {
                login = value;
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                password = value;
            }
        }
    }
}