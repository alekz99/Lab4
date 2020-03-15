
namespace Cross_app
{
    /// <summary>
    /// Класс абстрактной фабрики.
    /// </summary>
    abstract class AppFactory
    {
        public abstract IWindow CreateWindow();

        public abstract IMenu CreateMenu();

        public abstract IPath CreatePath();
    }
}
