using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace OpenAI.DotNet.Models.Responses
{
    public class ErrorResponse
    {
        public Error Error { get; set; }
    }
}
