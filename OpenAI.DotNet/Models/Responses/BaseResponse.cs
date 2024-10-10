
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace OpenAI.DotNet.Models.Responses
{
    public class BaseResponse<T>
    {
        [JsonProperty("data")]
        public virtual T Data { get; set; }
    }

}
