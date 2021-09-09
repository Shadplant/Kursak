namespace DataBase_Logic
{
    public class DatabaseConnectionSingleton
    {
        private static DatabaseConnectionSingleton instance;
        private static string connectionString = null;
        private DatabaseConnectionSingleton() { }

        public static DatabaseConnectionSingleton getInstance(string conStr="")
        {
            if (instance == null)
            {
                instance = new DatabaseConnectionSingleton();
                connectionString = conStr;
            }
            return instance;
        }

        public string getConnectionString()
        {
            return connectionString;
        }
    }
}