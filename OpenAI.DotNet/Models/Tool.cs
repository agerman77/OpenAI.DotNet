using OpenAI.DotNet.Enums;

namespace OpenAI.DotNet.Models
{
    public class Tool
    {
        public ToolType Type { get; set; }

        /// <summary>
        /// Only applies when tooltype = function
        /// </summary>
        public Function Function { get; set; }
    }
}