using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Catalog_Admin_GUI
{
    public class Admin_Login_Model : INotifyPropertyChanged
    {
        public bool Check_Email_Model(string Email)
        {
            return ServiceSingleton.getInstance().getService().Check_Email(Email);
        }

        public string Login_Admin_Model(string Email, string Password)
        {
            return ServiceSingleton.getInstance().getService().Login_Admin(Email, Password);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
