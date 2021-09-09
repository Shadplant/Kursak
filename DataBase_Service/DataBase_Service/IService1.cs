using System.ServiceModel;

namespace DataBase_Service
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IService1" в коде и файле конфигурации.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        void Add_Game(string Game_Name, string Game_Description, string Game_Image_Link, int Publishing_Admin_ID);

        [OperationContract]
        string Login_Admin(string Email, string Password);

        [OperationContract]
        bool Check_Email(string Email);
    }
}
