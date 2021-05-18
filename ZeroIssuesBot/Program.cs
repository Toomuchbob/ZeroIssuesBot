using System;
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

            // Get list of slash commands from commands.json
            var listOfCommands = CommandRegistrar.GetSlashCommands();

            // Register each command from the list
            foreach (var command in listOfCommands)
            {
                var res = await CommandRegistrar.AddApplicationCommand(Client, Token, command);
                Console.WriteLine(res);
            }
        }
    }
}
