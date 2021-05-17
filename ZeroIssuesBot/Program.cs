using System;
using System.Net;
using System.Threading.Tasks;

namespace ZeroIssuesBot
{
    class Program
    {
        static async Task Main(string[] args)
        {
            DiscordBotAuthorizer authorizer = new DiscordBotAuthorizer();

            Console.WriteLine(await authorizer.GetTokenResponse());
        }
    }
}
