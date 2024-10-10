
using OpenAI.DotNet.Enums;

namespace OpenAI.DotNet.Models
{
    public class Error
    {
        public ErrorType Code { get; set; }
        public string Message { get; set; }
    }
}
