using System;
using System.Collections.Generic;
using DataBase_Logic;
using Newtonsoft.Json;

namespace DataBase_Service
{
    public class ServiceUser : IServiceUser
    {
        DatabaseConnectionSingleton db = DatabaseConnectionSingleton.getInstance("Data Source=SQL5108.site4now.net;Initial Catalog=db_a7985d_clientdatabase;User Id=db_a7985d_clientdatabase_admin;Password=JoeSon12345678");

        public bool Check_Login(string Login)
        {
            return new User_Reposetory().Check_Login(Login);
        }

        public string Get_Game(int id)
        {
            return new Game_Reposetory().Get_Game(id);
        }

        public string Get_Games()
        {
            return new Game_Reposetory().Get_Games();
        }

        public string Get_News()
        {
            return new User_Reposetory().Get_News();
        }

        public string Get_Profile(int id)
        {
            return new User_Reposetory().Get_Profile(id);
        }

        public string Get_Reviews(int id)
        {
            return new Game_Reposetory().Get_Reviews(id);
        }

        public int Login_User(string Login, string Password)
        {
            throw new NotImplementedException();
        }

        public int Register_User(string Email, string Login, string Password)
        {
            throw new NotImplementedException();
        }

        public void Review_User(string serialized_review)
        {
            throw new NotImplementedException();
        }
    }
}
