using System.Collections.Generic;

namespace StructuralPatterns.Proxy
{
    public interface IThirdPartyYouTubeLib
    {
        List<string> ListVideos();
        string GetVideoInfo(string name);
        string DownloadVideo(string name);
    }
}
