using System;

namespace Cross_app
{
    class Windows : AppFactory
    {
        private string _nameOS = "Windows";
        public Windows()
        {
            Console.WriteLine("--Creating params for " + _nameOS);
        }
        public override IWindow CreateWindow()
        {
            Console.WriteLine("--Window settings made for " + _nameOS);
            return new WindowsWindow();
        }

        public override IMenu CreateMenu()
        {
            Console.WriteLine("--Menu settings made for " + _nameOS);
            return new WindowsMenu();
        }

        public override IPath CreatePath()
        {
            Console.WriteLine("--Path chosen for " + _nameOS);
            return new WindowsPath();
        }
    }

    class WindowsWindow : IWindow
    {
        public WindowsWindow()
        {
            Size();
            CountButton();
        }
        public void Size()
        {
            Console.WriteLine("----Size customized");
        }

        public void CountButton()
        {
            Console.WriteLine("----4 button customized ");
        }

    }

    class WindowsMenu : IMenu
    {
        public WindowsMenu()
        {
            MenuTheme();
        }
        public void MenuTheme()
        {
            Console.WriteLine("----Theme 1");
        }
    }

    class WindowsPath : IPath
    {
        public WindowsPath()
        {
            RootPath();
        }
        public void RootPath()
        {
            Console.WriteLine("----Root path for Windows customized");
        }
    }
}
