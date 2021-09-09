﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Admin_Login_Model : INotifyPropertyChanged
    {
        public bool Check_Email_Model(string Email)
        {
            return Connection().Check_Email(Email);
        }

        public string Login_Admin_Model(string Email, string Password)
        {
            return Connection().Login_Admin(Email, Password);
        }

        private IService1 Connection()
        {
            
            Uri uri = new Uri(ConfigurationManager.ConnectionStrings["ServerConn"].ConnectionString);
            EndpointAddress endpointAddress = new EndpointAddress(uri);
            BasicHttpBinding binding = new BasicHttpBinding();
            ChannelFactory<IService1> channelFactory = new ChannelFactory<IService1>(binding, endpointAddress);
            IService1 service = channelFactory.CreateChannel();
            return service;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
