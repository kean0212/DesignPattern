using System;

namespace CreationalPatterns.AbstractFactory
{
    class MacButton : IButton
    {
        public MacButton()
        {
            Console.WriteLine("MacButton is created.");
        }
    }
}