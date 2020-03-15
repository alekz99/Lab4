using System;

namespace Cross_app
{
    class OrderApplication
    {
        private IWindow _window;
        private IMenu _menu;
        private IPath _path;

        public OrderApplication(AppFactory factory)
        {
            _window = factory.CreateWindow();
            _menu = factory.CreateMenu();
            _path = factory.CreatePath();
        }
    }
}
