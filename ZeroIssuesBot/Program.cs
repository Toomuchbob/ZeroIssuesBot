using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace ZeroIssuesBot
{
    class Program
    {
        private static HttpClient Client = new HttpClient();
        static async Task Main(string[] args)
        {

            // get a new access token from discord api
            DiscordBotAuthorizer authorizer = new DiscordBotAuthorizer();
            DiscordToken Token = DiscordToken.GetTokenFromResponse(await authorizer.GetTokenResponse(Client));

            Console.WriteLine(Token.access_token);

            var command = JsonConvert.DeserializeObject<SlashCommand>(File.ReadAllText(@"C:\Users\GinoZacc\source\repos\ZeroIssuesBot\ZeroIssuesBot\commands.json"));
        }
    }
}
