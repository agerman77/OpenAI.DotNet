using OpenAI.DotNet.Enums;
using OpenAI.DotNet.Helpers.Converters;
using Newtonsoft.Json;

namespace OpenAI.DotNet.Models
{
    [JsonConverter(typeof(BaseConverter))]
    public abstract class Annotation
    {
        public string Text { get; set; }
        public ObjectType Type { get; set; }
        public int StartIndex { get; set; }
        public int EndIndex { get; set; }
    }
}