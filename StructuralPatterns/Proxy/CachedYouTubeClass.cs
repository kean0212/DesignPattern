using System.Collections.Generic;

namespace StructuralPatterns.Proxy
{
    public class CachedYouTubeClass : IThirdPartyYouTubeLib
    {
        private readonly IThirdPartyYouTubeLib _service;
        private List<string> _listCache;
        private Dictionary<string, string> _videoCache;

        public CachedYouTubeClass(IThirdPartyYouTubeLib service)
        {
            _service = service;
        }

        public string DownloadVideo(string name)
        {
            _videoCache ??= new Dictionary<string, string>();
            if (!_videoCache.ContainsKey(name))
            {
                _videoCache[name] = _service.DownloadVideo(name);
            }
            return _videoCache[name];
        }

        public string GetVideoInfo(string name)
        {
            _videoCache ??= new Dictionary<string, string>();
            if (!_videoCache.ContainsKey(name))
            {
                _videoCache[name] = _service.GetVideoInfo(name);
            }
            return _videoCache[name];
        }

        public List<string> ListVideos()
        {
            _listCache ??= _service.ListVideos();
            return _listCache;
        }
    }
}
