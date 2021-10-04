﻿using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Catalog_User_GUI
{
    public class User_Login_ViewModel : INotifyPropertyChanged
    {
        User_Login_Model model = new User_Login_Model();
        private string email;
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

        public bool Check_Email_ViewModel()
        {
            try
            {
                return model.Check_Email_Model(Email.ToLower());
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

            if (Check_Email_ViewModel())
            {
                isAutorize = true;
            }

            return isAutorize;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}