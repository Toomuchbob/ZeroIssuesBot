using System;
using System.Net;
using System.Threading.Tasks;

namespace ZeroIssuesBot
{
    class Program
    {
        private static DiscordToken Token { get; set; }

        static async Task Main(string[] args)
        {
            DiscordBotAuthorizer authorizer = new DiscordBotAuthorizer();

            Token = DiscordToken.GetTokenFromResponse(await authorizer.GetTokenResponse());
        }
    }
}
