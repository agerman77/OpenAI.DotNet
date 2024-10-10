﻿using OpenAI.DotNet.Helpers.Serialization;
using Newtonsoft.Json;
using System.ComponentModel;

namespace OpenAI.DotNet.Enums
{
    [JsonConverter(typeof(CustomGenericEnumConverter<ChatCompletionContentPartType>))]
    public enum ChatCompletionContentPartType
    {
        [Description("text")]
        Text = 1,
        [Description("image_url")]
        ImageUrl = 2,
    }
}