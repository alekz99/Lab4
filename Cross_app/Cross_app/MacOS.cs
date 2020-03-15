using System;
using System.Collections.Generic;
using System.Text;

namespace Cross_app
{
    /// <summary>
    /// Класс, создающий приложение под Mac OS
    /// </summary>
    class MacOS : AppFactory
    {
        private string _nameOS = "Mac OS";
        public MacOS()
        {
            Console.WriteLine("--Creating params for " + _nameOS);
        }
        public override IWindow CreateWindow()
        {
            Console.WriteLine("--Window settings made for " + _nameOS);
            return new MacOSWindow();
        }

        public override IMenu CreateMenu()
        {
            Console.WriteLine("--Menu settings made for " + _nameOS);
            return new MacOSMenu();
        }

        public override IPath CreatePath()
        {
            Console.WriteLine("--Path chosen for " + _nameOS);
            return new MacOSPath();
        }
    }

    class MacOSWindow : IWindow
    {
        public MacOSWindow()
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
            Console.WriteLine("----3 button customized ");
        }
    }

    class MacOSMenu : IMenu
    {
        public MacOSMenu()
        {
            MenuTheme();
        }
        public void MenuTheme()
        {
            Console.WriteLine("----Theme 3");
        }
    }

    class MacOSPath : IPath
    {
        public MacOSPath()
        {
            RootPath();
        }
        public void RootPath()
        {
            Console.WriteLine("----Root path for Mac OS customized");
        }
    }
}
