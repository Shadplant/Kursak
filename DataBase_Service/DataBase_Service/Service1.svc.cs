using System;
using DataBase_Logic;
using Newtonsoft.Json;

namespace DataBase_Service
{
    public class Service1 : IService1
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
    }
}
