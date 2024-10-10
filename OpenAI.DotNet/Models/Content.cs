using OpenAI.DotNet.Enums;
using OpenAI.DotNet.Helpers.Converters;
using Newtonsoft.Json;

namespace OpenAI.DotNet.Models
{
    [JsonConverter(typeof(BaseConverter))]
    public abstract class Content
    {
        public  ObjectType Type { get; set; }
    }
}
