using System;

namespace Cross_app
{

    class Program
    {
        /// <summary>
        /// Точка входа для приложения.
        /// </summary>
        /// <param name="args">Список аргументов командной строки</param>
        static void Main(string[] args)
        {
            Application app = new Application();
            app.CreateOrderApplication();
            Console.WriteLine("The end program");
        }
    }
}
