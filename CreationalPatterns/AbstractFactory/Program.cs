using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IGuiFactory factory;
            Console.WriteLine("What OS:");
            var os = Console.ReadLine();
            if (string.Equals("windows", os, StringComparison.OrdinalIgnoreCase))
            {
                factory = new WinFactory();
            }
            else if (string.Equals("mac", os, StringComparison.OrdinalIgnoreCase))
            {
                factory = new MacFactory();
            }
            else
            {
                throw new NotImplementedException();
            }
            
            Console.WriteLine("Creating button...");
            var button = factory.CreateButton();
            Console.WriteLine("Creating checkbox...");
            var checkBox = factory.CreateCheckbox();

            Console.WriteLine("Painting the GUI...");
            factory.Paint();
        }
    }
}
