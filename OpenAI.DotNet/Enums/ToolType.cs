﻿using OpenAI.DotNet.Helpers.Serialization;
using Newtonsoft.Json;
using System.ComponentModel;

namespace OpenAI.DotNet.Enums
{
    [JsonConverter(typeof(CustomGenericEnumConverter<ToolType>))]
    public enum ToolType
    {
        [Description("code_interpreter")]
        CodeInterpreter = 1,
        [Description("retrieval")]
        Retrieval = 2,
        [Description("function")]
        Function = 3,
    }
}