using OpenAI.DotNet.Helpers.Converters;
using Newtonsoft.Json;

namespace OpenAI.DotNet.Models
{
    [JsonConverter(typeof(BaseConverter))]
    public abstract class StepDetailsToolCall: ToolCall
    {

    }
}