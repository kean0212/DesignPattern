using System;

namespace CreationalPatterns.FactoryMethod
{
    public class HtmlButton : IButton
    {
        public void OnClick()
        {
            Console.WriteLine($"{nameof(HtmlButton)}.{nameof(OnClick)}");
        }

        public void Render()
        {
            Console.WriteLine($"{nameof(HtmlButton)}.{nameof(Render)}");
        }
    }
}