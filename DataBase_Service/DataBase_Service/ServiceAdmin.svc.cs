using System;
using System.Collections.Generic;
using DataBase_Logic;
using Newtonsoft.Json;

namespace DataBase_Service
{
    public class ServiceAdmin : IServiceAdmin
    {
        DatabaseConnectionSingleton db = DatabaseConnectionSingleton.getInstance("Data Source=SQL5108.site4now.net;Initial Catalog=db_a7985d_clientdatabase;User Id=db_a7985d_clientdatabase_admin;Password=JoeSon12345678");
        public void Add_Game(string serialized_game)
        {
            new Game_Reposetory().Add_Game(JsonConvert.DeserializeObject<Game>(serialized_game));
        }

        public void Delete_Game(int id)
        {
            new Game_Reposetory().Delete_Game(id);
        }

        public void Edit_Game(string serialized_game)
        {
            new Game_Reposetory().Edit_Game(JsonConvert.DeserializeObject<Game>(serialized_game));
        }

        public string Get_Games()
        {
            return new Game_Reposetory().Get_Games();
        }

        public bool Check_Email(string Email)
        {
            return new Admin_Reposetory().Check_Email(Email);
        }

        public string Login_Admin(string Email, string Password)
        {
            return new Admin_Reposetory().Login_Admin(Email, Password);
        }

        public List<string> Get_Admin_List(int id)
        {
            return new Admin_Reposetory().Get_Admin_List(id);
        }

        public void Refer_Admin(int id, string Email, string Password)
        {
            new Admin_Reposetory().Refer_Admin(id, Email, Password);
        }
    }
}
