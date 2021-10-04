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
        void Add_Game(string Game_Name, string Game_Description, string Game_Image_Link, int Publishing_Admin_ID);

        [OperationContract]
        string Login_Admin(string Email, string Password);

        [OperationContract]
        void Refer_Admin(string Email, string Password);

        [OperationContract]
        bool Check_Email(string Email);

        [OperationContract]
        bool Add_Admin(string Email, string Password);
    }
}
