using System;

namespace Cross_app
{

    class Program
    {
        static void Main(string[] args)
        {
            Application app = new Application();
            app.CreateOrderApplication();
            Console.WriteLine("The end program");
        }
    }
}
