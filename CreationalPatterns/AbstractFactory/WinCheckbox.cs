using System;

namespace CreationalPatterns.AbstractFactory
{
    class WinCheckbox : ICheckbox
    {
        public WinCheckbox()
        {
            Console.WriteLine("WinCheckbox is created.");
        }
    }
}
