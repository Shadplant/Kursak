
using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace DataBase_Logic
{
    public class Admin_Reposetory
    {
        public bool Check_Email(string Email)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnectionSingleton.getInstance().getConnectionString()))
            {
                return conn.Query<string>("EXEC Check_Admin_Email \'" + Email + "\'").FirstOrDefault()?.Length > 0;
            }
        }

        public string Login_Admin(string Email, string Password)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnectionSingleton.getInstance().getConnectionString()))
            {
                return conn.Query<string>("EXEC Login_Admin \'"+Email+"\' ,\'"+Password+"\'").FirstOrDefault();
            }
        }

        public List<string> Get_Admin_List(int id)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnectionSingleton.getInstance().getConnectionString()))
            {
                return conn.Query<string>("EXEC Get_Refered_Admins " + id).ToList();
            }
        }

        public void Refer_Admin(int id, string Email, string Password)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnectionSingleton.getInstance().getConnectionString()))
            {
                conn.Execute("EXEC Login_Admin " + id + ",\'" + Password + "\' ,\'" + Email + "\' ,\'");
            }
        }
    }
}