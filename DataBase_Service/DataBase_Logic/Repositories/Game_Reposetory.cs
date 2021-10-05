using Dapper;
using Newtonsoft.Json;
using System.Linq;
using System.Collections.ObjectModel;
using System.Data.SqlClient;

namespace DataBase_Logic
{
    public class Game_Reposetory
    {
        public void Add_Game(Game game)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnectionSingleton.getInstance().getConnectionString()))
            {
                conn.Execute("EXEC Add_Game \'"+ game.Game_Name +"\', \'"+game.Game_Description+"\', \'"+game.Game_Image_Link+"\', \'" + game.Game_Link + "\'");
            }
        }

        public string Get_Games()
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnectionSingleton.getInstance().getConnectionString()))
            {
                return JsonConvert.SerializeObject(conn.Query<Game>("EXEC Get_Games").ToList());
            }
        }

        public void Edit_Game(Game game)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnectionSingleton.getInstance().getConnectionString()))
            {
                conn.Execute("EXEC Edit_Game " + game.Game_ID + ", \'" + game.Game_Name + "\', \'" + game.Game_Description + "\', \'" + game.Game_Image_Link + "\', \'" + game.Game_Link);
            }
        }

        public void Delete_Game(int id)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnectionSingleton.getInstance().getConnectionString()))
            {
                conn.Execute("EXEC Delete_Game " + id);
            }
        }
    }
}