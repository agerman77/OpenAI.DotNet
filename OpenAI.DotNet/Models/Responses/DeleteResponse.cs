using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using OpenAI.DotNet.Enums;

namespace OpenAI.DotNet.Models.Responses
{
    public class DeleteResponse
    {
        public string Id { get; set; }

        [JsonProperty("object")]
        public ObjectType Type { get; set; }
        public bool Deleted { get; set; }
    }
}