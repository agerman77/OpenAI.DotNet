using OpenAI.DotNet.Models;
using OpenAI.DotNet.Models.Responses;
using RestSharp;

namespace OpenAI.DotNet
{
    public class AssistantFileRepository : BaseRepository
    {
        public AssistantFileRepository(string apiKey, string baseUrl = "https://api.openai.com/v1/assistants")
        {
            ApiKey = apiKey;
            BaseUrl = baseUrl;
        }

        public async Task<AssistantFile> CreateAssistantFileAsync(string assistantId, string fileId)
        {
            return await PrepareAndMakeRequest<AssistantFile>($"{BaseUrl}/{assistantId}/files", Method.POST, bodyObject: new { file_id = fileId });
        }

        public async Task<AssistantFile> GetAssistantFileAsync(string assistantId, string fileId)
        {
            return await PrepareAndMakeRequest<AssistantFile>($"{BaseUrl}/{assistantId}/files/{fileId}");
        }

        public async Task<DeleteResponse> DeleteAssistantFileAsync(string assistantId, string fileId)
        {
            return await PrepareAndMakeRequest<DeleteResponse>($"{BaseUrl}/{assistantId}/files/{fileId}", Method.DELETE);
        }

        public async Task<PagedResponse<AssistantFile>> GetAssistantFilesAsync(string assistantId)
        {
            return await PrepareAndMakeRequest<PagedResponse<AssistantFile>>($"{BaseUrl}/{assistantId}/files");
        }
    }

}
