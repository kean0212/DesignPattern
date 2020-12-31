using System;

namespace StructuralPatterns.Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a remote control for the TV
            var tv = new Tv();
            var tvRemoteControl = new RemoteControl(tv);
            tvRemoteControl.TogglePower();

            // Create an advanced remote control for a radio
            var radio = new Radio();
            var radioRemoteControl = new AdvancedRemoteControl(radio);
            radioRemoteControl.Mute();
        }
    }
}
