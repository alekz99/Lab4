using System;

namespace Cross_app
{
    /// <summary>
    /// Класс формы приложения.
    /// </summary>
    class OrderApplication
    {
        private IWindow _window;
        private IMenu _menu;
        private IPath _path;

        /// <summary>
        /// Конструктор для создания приложения под определенную платформу.
        /// </summary>
        /// <param name="factory">Абстрактный класс с интерфейсами для реализации</param>
        public OrderApplication(AppFactory factory)
        {
            _window = factory.CreateWindow();
            _menu = factory.CreateMenu();
            _path = factory.CreatePath();
        }
    }
}
