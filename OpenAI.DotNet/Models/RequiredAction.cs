using OpenAI.DotNet.Enums;

namespace OpenAI.DotNet.Models
{
    public class RequiredAction
    {
        public ObjectType Type { get; set; }
        public SubmitToolOutputs SubmitToolOutputs { get; set; }
    }
}