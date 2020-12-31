namespace StructuralPatterns.Bridge
{
    public class Radio : IDevice
    {
        private bool _isEnabled;
        private int _channel;
        private int _volume;

        public void Disable()
        {
            _isEnabled = false;
        }

        public void Enable()
        {
            _isEnabled = true;
        }

        public int GetChannel()
        {
            return _channel;
        }

        public int GetVolume()
        {
            return _volume;
        }

        public bool IsEnabled()
        {
            return _isEnabled;
        }

        public void SetChannel(int channel)
        {
            _channel = channel;
        }

        public void SetVolume(int volume)
        {
            _volume = volume;
        }
    }
}
