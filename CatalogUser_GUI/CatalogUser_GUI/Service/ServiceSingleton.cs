using DataBase_Service;
using System;
using System.Configuration;
using System.ServiceModel;

namespace Catalog_User_GUI
{
    class ServiceSingleton
    {
        private static ServiceSingleton instance;
        private static Uri uri;
        private static EndpointAddress endpointAddress;
        private static BasicHttpBinding binding;
        private static ChannelFactory<IService1> channelFactory;
        private static IService1 service;
    

        private ServiceSingleton()
        { }

        public static ServiceSingleton getInstance()
        {
            if (instance == null)
            {
                instance = new ServiceSingleton();
                uri = new Uri(ConfigurationManager.ConnectionStrings["ServerConn"].ConnectionString);
                endpointAddress = new EndpointAddress(uri);
                binding = new BasicHttpBinding();
                channelFactory = new ChannelFactory<IService1>(binding, endpointAddress);
                service = channelFactory.CreateChannel();
            }
            return instance;
        }

       public IService1 getService() => service;
    }
}
