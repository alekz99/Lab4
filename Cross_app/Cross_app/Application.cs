using System;

namespace Cross_app
{
    class Application
    {
        private OrderApplication orderApplication;
        public void CreateOrderApplication()
        {
            Console.WriteLine("Choose OS: Mac OS, Windows, Ubuntu");
            string osName = Console.ReadLine();
            AppFactory appFactory;

            if (osName == "Windows")
            {
                appFactory = new Windows();
            }
            else if (osName == "Mac OS")
            {
                appFactory = new MacOS();
            }
            else
            {
                appFactory = new Ubuntu();
            }

            orderApplication = new OrderApplication(appFactory);
        }
    }
}
