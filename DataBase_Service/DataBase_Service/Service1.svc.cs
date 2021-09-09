using System;
using DataBase_Logic;
namespace DataBase_Service
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы Service1.svc или Service1.svc.cs в обозревателе решений и начните отладку.
    public class Service1 : IService1
    {
        DatabaseConnectionSingleton db = DatabaseConnectionSingleton.getInstance("Data Source=SQL5108.site4now.net;Initial Catalog=db_a7985d_clientdatabase;User Id=db_a7985d_clientdatabase_admin;Password=JoeSon12345678");
        public void Add_Game(string Game_Name, string Game_Description, string Game_Image_Link, int Publishing_Admin_ID)
        {
           

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
