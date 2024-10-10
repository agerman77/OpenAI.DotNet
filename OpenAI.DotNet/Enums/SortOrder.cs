﻿using OpenAI.DotNet.Helpers.Serialization;
using Newtonsoft.Json;
using System.ComponentModel;

namespace OpenAI.DotNet.Enums
{
    [JsonConverter(typeof(CustomGenericEnumConverter<SortOrder>))]
    public enum SortOrder
    {
        [Description("asc")]
        Ascending = 1,
        [Description("desc")]
        Descending = 2,
    }
}