using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Catalog_GUI
{
    public class Game_Add_Model : INotifyPropertyChanged
    {

        public void Add_Game_Model(string Game_Name, string Game_Description, string Game_Image_Link, int Publishing_Admin_ID)
        {
            ServiceSingleton.getInstance().getService().Add_Game(Game_Name, Game_Description, Game_Image_Link, Publishing_Admin_ID);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

    }
}
