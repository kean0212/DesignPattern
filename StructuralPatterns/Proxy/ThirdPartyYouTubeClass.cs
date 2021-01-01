using System.Collections.Generic;

namespace StructuralPatterns.Proxy
{
    public class ThirdPartyYouTubeClass : IThirdPartyYouTubeLib
    {
        public string DownloadVideo(string name)
        {
            return $"Video: {name}";
        }

        public string GetVideoInfo(string name)
        {
            return $"Video Info: {name}";
        }

        public List<string> ListVideos()
        {
            return new List<string>();
        }
    }
}
