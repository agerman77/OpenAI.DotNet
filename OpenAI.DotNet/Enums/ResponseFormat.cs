using OpenAI.DotNet.Helpers.Serialization;
using Newtonsoft.Json;
using System.ComponentModel;

namespace OpenAI.DotNet.Enums
{
    [JsonConverter(typeof(CustomGenericEnumConverter<ResponseFormat>))]
    public enum ResponseFormat
    {
        [Description("text")]
        Text = 1,
        [Description("json_object")]
        Json = 2
    }
}