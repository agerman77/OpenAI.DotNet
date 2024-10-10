using OpenAI.DotNet.Enums;

namespace OpenAI.DotNet.Models
{
    public class ToolCall
    {
        public string Id { get; set; }
        public ObjectType Type { get; set; }
        public ToolFunction Function { get; set; }
    }
}