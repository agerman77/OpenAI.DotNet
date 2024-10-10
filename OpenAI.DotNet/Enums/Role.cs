﻿using OpenAI.DotNet.Helpers.Serialization;
using Newtonsoft.Json;
using System.ComponentModel;

namespace OpenAI.DotNet.Enums
{
    
    [JsonConverter(typeof(CustomGenericEnumConverter<Role>))]
    public enum Role
    {
        [Description("user")]
        User = 1,
        [Description("assistant")]
        Assistant = 2,
        [Description("system")]
        System = 3,
        [Description("tool")]
        Tool = 4,
    }
}
