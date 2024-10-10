
using OpenAI.DotNet.Enums;

namespace OpenAI.DotNet.Models
{
    public class ChatCompletionImageContentPart: ChatCompletionContentPart
    {
        public ChatCompletionImageContentPart(ImageContentPart imageContentPart)
        {
            Type = ChatCompletionContentPartType.Text;
            ImageContentPart = imageContentPart;
        }

        public ImageContentPart ImageContentPart {  get; private set; }
    }
}
