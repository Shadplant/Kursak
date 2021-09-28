using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace Catalog_GUI
{
    public class Admin_Refer_ViewModel : Base_Model
    {
        Admin_Refer_Model model = new Admin_Refer_Model();
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

        private RelayCommand refer_command;
        public RelayCommand Refer_Command
        {
            get
            {
                return refer_command ?? (refer_command = new RelayCommand(obj => Refer_Admin_ViewModel()));
            }
        }

        public bool Check_Email_ViewModel()
        {
            try
            {
                return model.Check_Email_Model(Email);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool Refer_Admin_ViewModel()
        {
            bool exists = false;

            if (Check_Email_ViewModel())
            {
                exists = true;
            }

            return exists;
        }
    }
}
