using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using DataBase_Service;

namespace Catalog_Admin_GUI
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
        List<string> Get_Admin_List(int id);

        [OperationContract]
        void Refer_Admin(int id, string Email, string Password);

        [OperationContract]
        string Login_Admin(string Email, string Password);

        [OperationContract]
        bool Check_Email(string Email);
    }
}
