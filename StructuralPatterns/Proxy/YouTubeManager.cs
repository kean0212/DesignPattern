namespace StructuralPatterns.Proxy
{
    public class YouTubeManager
    {
        private readonly IThirdPartyYouTubeLib _service;

        public YouTubeManager(IThirdPartyYouTubeLib service)
        {
            _service = service;
        }

        public void RenderVideoPage(string name)
        {
            var videoInfo = _service.GetVideoInfo(name);
        }

        public void RenderListPanel()
        {
            var videos = _service.ListVideos();
        }

        public void ReactOnUserInput()
        {
            RenderVideoPage("home");
            RenderListPanel();
        }
    }
}
