using StructuralPatterns.Facade.VideoConversionFramework;

namespace StructuralPatterns.Facade
{
    /// <summary>
    /// This class serves as the facade
    /// </summary>
    public class VideoConverter
    {
        public VideoFile Convert(string fileName, string format)
        {
            var videoFile = new VideoFile(fileName);
            var sourceCodec = CodecFactory.Extract(videoFile);
            CompressionCodec destinationCodec;
            if (format == "mp4")
            {
                destinationCodec = new MPEGCompressionCodec();
            }
            else
            {
                destinationCodec = new OggCompressionCodec();
            }
            var buffer = BitrateReader.Read(fileName, sourceCodec);
            var result = BitrateReader.Convert(buffer, destinationCodec);
            result = (new AudioMixer()).Fix(result);
            return new VideoFile(result);
        }
    }
}
