using System;
/// <summary>
/// The classes in this namespace are those systems/services used provided by the framework.
/// </summary>
namespace StructuralPatterns.Facade.VideoConversionFramework
{
    public class VideoFile
    {
        private readonly string _fileName;
        private object result;

        public CompressionCodec CompressionCodec { get; set; }

        public VideoFile(string fileName)
        {
            _fileName = fileName;
        }
    }

    public class CompressionCodec
    {

    }

    public class OggCompressionCodec : CompressionCodec
    {

    }

    public class MPEGCompressionCodec : CompressionCodec
    {

    }

    public class CodecFactory
    {
        internal static CompressionCodec Extract(VideoFile videoFile)
        {
            return videoFile.CompressionCodec;
        }
    }

    public class BitrateReader
    {
        internal static string Convert(string buffer, CompressionCodec destinationCodec)
        {
            return $"{nameof(destinationCodec)}: {buffer}";
        }

        internal static string Read(string fileName, CompressionCodec sourceCodec)
        {
            return $"{nameof(sourceCodec)}: {fileName}";
        }
    }

    public class AudioMixer
    {
        internal string Fix(string result)
        {
            return $"Audio fixed: {result}";
        }
    }
}
