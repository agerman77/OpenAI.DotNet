﻿
namespace OpenAI.DotNet.Models
{
    public class ThreadMessageCreationStepDetails: StepDetails
    {
        public string Id { get; set; }
        
        public ThreadMessageCreation MessageCreation { get; set; }
    }
}