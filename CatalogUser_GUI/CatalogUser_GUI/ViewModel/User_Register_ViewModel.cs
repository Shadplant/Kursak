using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace Catalog_User_GUI
{
    public class User_Register_ViewModel : Base_Model
    {
        User_Register_Model model = new User_Register_Model();
        private string email;
        private string login;
        private string password;

        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                OnPropertyChanged("Email");
            }
        }

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

        private RelayCommand register_command;
        public RelayCommand Register_command
        {
            get
            {
                return register_command ?? (register_command = new RelayCommand(obj => Register_User_ViewModel()));
            }
        }

        public bool Register_User_ViewModel()
        {
            model.Register_User_Model(email, login, password);
            return true;
        }
    }
}
