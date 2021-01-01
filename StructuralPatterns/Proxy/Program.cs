using System;

namespace StructuralPatterns.Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            var youTubeService = new ThirdPartyYouTubeClass();
            var youTubeServiceProxy = new CachedYouTubeClass(youTubeService);
            var youTubeManager = new YouTubeManager(youTubeServiceProxy);
            youTubeManager.ReactOnUserInput();
        }
    }
}
