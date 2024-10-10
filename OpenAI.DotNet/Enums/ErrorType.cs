﻿using OpenAI.DotNet.Helpers.Serialization;
using Newtonsoft.Json;
using System.ComponentModel;

namespace OpenAI.DotNet.Enums
{
    [JsonConverter(typeof(CustomGenericEnumConverter<ErrorType>))]
    public enum ErrorType
    {
        [Description("server_error")]
        ServerError = 1,
        [Description("rate_limit_exceeded")]
        RateLimitExceeded = 2,
    }
}