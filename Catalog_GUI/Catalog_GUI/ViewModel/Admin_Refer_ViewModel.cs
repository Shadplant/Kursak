using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace Catalog_Admin_GUI
{
    public class Admin_Refer_ViewModel : Base_Model
    {
        public List<string> Refered_Admins { get; set; }

        Admin_Refer_Model model = new Admin_Refer_Model();
        private string email;
        private string password;

        public Admin_Refer_ViewModel()
        {
            Refered_Admins = model.Get_Admin_List(1);
        }

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

        public void Refer_Admin_ViewModel()
        {
            try
            {
                if (!Check_Email_ViewModel())
                {
                    model.Refer_Admin_Model(1, Email, Password);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
