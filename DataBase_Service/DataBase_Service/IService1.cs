using System.ServiceModel;

namespace DataBase_Service
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        void Add_Game(string serialized_game);

        [OperationContract]
        string Get_Games();

        [OperationContract]
        void Edit_Game(string serialized_game);

        [OperationContract]
        void Delete_Game(int id);

        [OperationContract]
        string Login_Admin(string Email, string Password);

        [OperationContract]
        bool Check_Email(string Email);
    }
}
