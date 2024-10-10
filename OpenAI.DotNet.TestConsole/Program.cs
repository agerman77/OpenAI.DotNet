using OpenAI.DotNet;
using OpenAI.DotNet.Models.Requests;
using OpenAI.DotNet.Models;

namespace GptModelingPOC
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            //await SimpleTest();
            await InteractiveTest();

            Console.ReadLine();
        }


        async static Task SimpleTest()
        {
            //set your OpenAI API key (https://platform.openai.com/settings/profile?tab=api-keys)
            string apiKey = "sk-mykey";

            //set the model to use
            string model = "gpt-4o-mini";// "gpt-3.5-turbo";


            ChatCompletionRepository chat = new ChatCompletionRepository(apiKey);
            chat.ChunkReceived += (ChatCompletionChunk cht) => {
                Console.Write(cht.Choices[0].Delta.Content);
            };

            const string assistantPersonality = "You are one extremely sarcastic nba sports analyst. Your job is to analyse basketball players professional career along their life and comment about their financial investments, but enjoy remarking their fails and addiction problems, as also love playing sarcastic jokes about them.";
            const string userRequest = "Write a two page article about Michael Jordan, his life in sports and business";

            Console.WriteLine($"sending request: {userRequest}");

            var chatCompRequest = new ChatCompletionRequest(
                    new List<ChatCompletionMessage>()
                            {
                                new ChatCompletionMessage()
                                {
                                    Content = assistantPersonality,
                                    Role = OpenAI.DotNet.Enums.Role.System
                                },
                                new ChatCompletionMessage()
                                {
                                    Content = userRequest,
                                    Role = OpenAI.DotNet.Enums.Role.User
                                }

                            },
                    model);


            try
            {
                //var response = await chat.CreateChatCompletionAsync(chatCompRequest);
                //Console.WriteLine(response.Choices[0].Message.Content);

                //streamed request
                chat.CreateChunkedChatCompletion(
                    chatCompRequest
                    );
            }

            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message} : {ex.StackTrace}");
            }
        }


        async static Task InteractiveTest()
        {
            //set your OpenAI API key (https://platform.openai.com/settings/profile?tab=api-keys)
            string apiKey = "sk-mykey";

            //set the model to use
            string model = "gpt-4o-mini";// "gpt-3.5-turbo";

            Console.WriteLine("Presione ctrl+c para cerrar...");

            const string assistantPersonality = "Eres una estratega de marketing de nombre Sara. Tu objetivo es dar estrategias de marketing, elaborar propuestas e investigar tendencias de mercado. Si alguien te hace alguna pregunta referente a otra temática, tienes que responder indicando que no estás autorizado a hablar de esos temas. Cuando termines de responder, no indiques FIN DE RESPUESTA, mas bien termina indicando que estas para ayudar si necesita algo...";

            Console.WriteLine("Hola! Soy Sara, tu estratega de marketing. Estoy aquí para ayudarte con lo que necesites.");

            ChatCompletionRepository chat = new ChatCompletionRepository(apiKey);
            chat.ChunkReceived += (ChatCompletionChunk cht) => {
                Console.Write(cht.Choices[0].Delta.Content);
            };



            while (true)
            {
                Console.WriteLine();

                string userRequest = Console.ReadLine(); 

                if (string.IsNullOrEmpty(userRequest))
                    continue;

                Console.WriteLine($"\nUsuario: {userRequest}\n\n");

                //Console.WriteLine($"you say you need {userRequest}.");

                var chatCompRequest = new ChatCompletionRequest(
                    new List<ChatCompletionMessage>()
                            {
                                new ChatCompletionMessage()
                                {
                                    Content = assistantPersonality,
                                    Role = OpenAI.DotNet.Enums.Role.System
                                },
                                new ChatCompletionMessage()
                                {
                                    Content = userRequest,
                                    Role = OpenAI.DotNet.Enums.Role.User,
                                }

                            },
                    model)
                { 
                      
                };

                try
                {
                    //var response = await chat.CreateChatCompletionAsync(chatCompRequest);
                    //Console.WriteLine(response.Choices[0].Message.Content);

                    //streamed request
                    chat.CreateChunkedChatCompletion(
                        chatCompRequest
                        );
                }

                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message} : {ex.StackTrace}");
                }
            }

            
        }


    }
}