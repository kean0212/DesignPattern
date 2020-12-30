using System;

namespace CreationalPatterns.AbstractFactory
{
    class WinButton : IButton
    {
        public WinButton()
        {
            Console.WriteLine("WinButton is created.");
        }
    }
}
