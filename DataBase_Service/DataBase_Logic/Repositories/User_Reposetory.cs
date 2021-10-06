using Dapper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DataBase_Logic
{
    public class User_Reposetory
    {
        public bool Check_Login(string Login)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnectionSingleton.getInstance().getConnectionString()))
            {
                return conn.Query<string>("EXEC Check_Admin_Email \'" + Login + "\'").FirstOrDefault()?.Length > 0;
            }
        }

        public string Get_News()
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnectionSingleton.getInstance().getConnectionString()))
            {
                return JsonConvert.SerializeObject(conn.Query<Game>("EXEC Get_News").ToList());
            }
        }

        public string Get_Profile(int id)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnectionSingleton.getInstance().getConnectionString()))
            {
                return JsonConvert.SerializeObject(conn.Query<User>("EXEC Get_Profile " + id).FirstOrDefault());
            }
        }


    }
}
