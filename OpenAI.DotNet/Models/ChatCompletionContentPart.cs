
using OpenAI.DotNet.Enums;

namespace OpenAI.DotNet.Models
{
    public abstract class ChatCompletionContentPart
    {
        public ChatCompletionContentPartType Type { get; set; }
    }
}
