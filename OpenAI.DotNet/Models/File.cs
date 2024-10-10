using OpenAI.DotNet.Enums;

namespace OpenAI.DotNet.Models
{
    public class File: BaseGptObject
    {
        public int Bytes { get; set; }

        public string FileName { get; set; }

        public FilePurpose Purpose { get; set; }

    }
}
