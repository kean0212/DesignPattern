using System;

namespace FactoryMethod
{
    class Program
    {
        public Dialog Dialog { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("What OS:");
            var os = Console.ReadLine();
            var program = new Program();
            if (string.Equals(os, "windows", StringComparison.OrdinalIgnoreCase))
            {
                program.Dialog = new WindowsDialog();
            }
            else if(string.Equals(os, "html", StringComparison.OrdinalIgnoreCase))
            {
                program.Dialog = new HtmlDialog();
            }
            else
            {
                throw new NotImplementedException("Input cannot be accepted.");
            }
            program.Dialog.Render();
        }
    }
}
