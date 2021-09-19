using Dapper;
using System.Data.SqlClient;

namespace DataBase_Logic
{
    public class Game_Reposetory
    {
        public void Add_Game(string Game_Name, string Game_Description, string Game_Image_Link, int Publishing_Admin_ID)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnectionSingleton.getInstance().getConnectionString()))
            {
                conn.Execute("EXEC Add_Game \'"+Game_Name+"\', \'"+Game_Description+"\', \'"+Game_Image_Link+"\', " + Publishing_Admin_ID.ToString() );
            }
        }
    }
}