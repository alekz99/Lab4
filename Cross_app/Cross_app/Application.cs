using System;

namespace Cross_app
{
    /// <summary>
    /// Класс, создающий приложение под определенную ОС.
    /// </summary>
    class Application
    {
        private OrderApplication orderApplication;
        /// <summary>
        /// Метод, определяющий тип операционной системы.
        /// </summary>
        public void CreateOrderApplication()
        {
            Console.WriteLine("Choose OS: Mac OS, Windows, Ubuntu");
            string osName = Console.ReadLine();
            AppFactory appFactory;

            if (osName.ToLower() == "Windows".ToLower())
            {
                appFactory = new Windows();
            }
            else if (osName.ToLower() == "Mac OS".ToLower())
            {
                appFactory = new MacOS();
            }
            else if (osName.ToLower() == "Ubuntu".ToLower())
            {
                appFactory = new Ubuntu();
            }
            else
            {
                throw new Exception("Wrong operation system");
            }


            orderApplication = new OrderApplication(appFactory);
        }
    }
}
