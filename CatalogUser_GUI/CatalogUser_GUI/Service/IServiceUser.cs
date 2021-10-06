using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using DataBase_Service;

namespace Catalog_User_GUI
{
    [ServiceContract]
    public interface IServiceUser
    {
        [OperationContract]
        string Get_Game(int id);

        [OperationContract]
        string Get_Reviews(int id);

        [OperationContract]
        string Get_Games();

        [OperationContract]
        int Login_User(string Login, string Password);

        [OperationContract]
        int Register_User(string Email, string Login, string Password);

        [OperationContract]
        bool Check_Login(string Login);

        [OperationContract]
        string Get_News();

        [OperationContract]
        void Review_User(string serialized_review);

        [OperationContract]
        string Get_Profile(int id);
    }
}
