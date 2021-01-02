
using System;

namespace StructuralPatterns.Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var converter = new VideoConverter();
            var mp4 = converter.Convert("funny-cats-video.ogg", "mp4");
        }
    }
}
