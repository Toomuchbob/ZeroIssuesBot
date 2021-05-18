using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ZeroIssuesBot
{
    static class CommandRegistrar
    {
        public static async Task<string> AddApplicationCommand(HttpClient client, DiscordToken token, SlashCommand command)
        {
            // Get resources from App.config
            var apiEndpoint = new Uri(ConfigurationManager.ConnectionStrings["apiEndpoint"].ToString());
            var clientId = ConfigurationManager.AppSettings["client_id"];
            var guildId = ConfigurationManager.ConnectionStrings["guildId"].ConnectionString;

            // Get Uri for request
            Uri requestUri = new Uri($"{apiEndpoint}/applications/{clientId}/guilds/{guildId}/commands");

            // Create a new request
            var request = new HttpRequestMessage(HttpMethod.Post, requestUri);
            request.Headers.Authorization = new AuthenticationHeaderValue(token.token_type, token.access_token);

            // Set the request content type
            request.Content = new StringContent(JsonConvert.SerializeObject(command));
            request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            // Ask for a response from the request
            var response = await client.SendAsync(request);

            return await response.Content.ReadAsStringAsync();
        }

        public static List<SlashCommand> GetSlashCommands()
        {
            return JsonConvert.DeserializeObject<List<SlashCommand>>(File.ReadAllText(@"C:\Users\GinoZacc\source\repos\ZeroIssuesBot\ZeroIssuesBot\commands.json"));
        }
    }
}
