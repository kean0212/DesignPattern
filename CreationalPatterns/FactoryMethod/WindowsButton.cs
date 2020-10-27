using System;

namespace CreationalPatterns.FactoryMethod
{
    public class WindowsButton : IButton
    {
        public void OnClick()
        {
            Console.WriteLine($"{nameof(WindowsButton)}.{nameof(OnClick)}");
        }

        public void Render()
        {
            Console.WriteLine($"{nameof(WindowsButton)}.{nameof(Render)}");
        }
    }
}