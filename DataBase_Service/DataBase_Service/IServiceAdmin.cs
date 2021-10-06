using System.Collections.Generic;
using System.ServiceModel;

namespace DataBase_Service
{
    [ServiceContract]
    public interface IServiceAdmin
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
        List<string> Get_Admin_List(int id);

        [OperationContract]
        void Refer_Admin(int id, string Email, string Password);

        [OperationContract]
        string Login_Admin(string Email, string Password);

        [OperationContract]
        bool Check_Email(string Email);
    }
}
