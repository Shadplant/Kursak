using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Catalog_User_GUI
{
    public class User_Login_ViewModel : Base_Model
    {
        User_Login_Model model = new User_Login_Model();
        private string login;
        private string password;

        public string Login
        {
            get { return login; }
            set
            {
                login = value;
                OnPropertyChanged("Login");
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged("Password");
            }
        }

        private RelayCommand login_command;
        public RelayCommand Login_Command
        {
            get
            {
                return login_command ?? (login_command = new RelayCommand(obj => Login_User_ViewModel()));
            }
        }

        public bool Check_Login_ViewModel()
        {
            try
            {
                return model.Check_Login_Model(Login.ToLower());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool Login_User_ViewModel()
        {
            bool isAutorize = false;

            if (Check_Login_ViewModel())
            {
                isAutorize = true;
            }

            return isAutorize;
        }
    }
}
