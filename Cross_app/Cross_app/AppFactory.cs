
namespace Cross_app
{
    abstract class AppFactory
    {
        public abstract IWindow CreateWindow();

        public abstract IMenu CreateMenu();

        public abstract IPath CreatePath();
    }
}
