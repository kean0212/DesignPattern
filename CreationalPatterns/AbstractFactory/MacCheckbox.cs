using System;

namespace CreationalPatterns.AbstractFactory
{
    class MacCheckbox : ICheckbox
    {
        public MacCheckbox()
        {
            Console.WriteLine("MacCheckbox is created.");
        }
    }
}