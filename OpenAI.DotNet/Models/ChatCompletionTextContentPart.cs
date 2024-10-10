
using OpenAI.DotNet.Enums;

namespace OpenAI.DotNet.Models
{
    public class ChatCompletionTextContentPart: ChatCompletionContentPart
    {
        public ChatCompletionTextContentPart(string text)
        {
            Type = ChatCompletionContentPartType.Text;
            Text = text;
        }

        public string Text {  get; private set; }
    }
}
