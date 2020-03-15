using System;
using System.Collections.Generic;
using System.Text;

namespace Cross_app
{
    class Ubuntu : AppFactory
    {
        private string _nameOS = "Ubuntu";
        public Ubuntu()
        {
            Console.WriteLine("--Creating params for " + _nameOS);
        }
        public override IWindow CreateWindow()
        {
            Console.WriteLine("--Window settings made for " + _nameOS);
            return new UbuntuWindow();
        }

        public override IMenu CreateMenu()
        {
            Console.WriteLine("--Menu settings made for " + _nameOS);
            return new UbuntuMenu();
        }

        public override IPath CreatePath()
        {
            Console.WriteLine("--Path chosen for " + _nameOS);
            return new UbuntuPath();
        }
    }

    class UbuntuWindow : IWindow
    {
        public UbuntuWindow()
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
            Console.WriteLine("----7 button customized ");
        }
    }

    class UbuntuMenu : IMenu
    {
        public UbuntuMenu()
        {
            MenuTheme();
        }
        public void MenuTheme()
        {
            Console.WriteLine("----Theme 2");
        }
    }

    class UbuntuPath : IPath
    {
        public UbuntuPath()
        {
            RootPath();
        }
        public void RootPath()
        {
            Console.WriteLine("----Root path for Ubuntu customized");
        }
    }
}
