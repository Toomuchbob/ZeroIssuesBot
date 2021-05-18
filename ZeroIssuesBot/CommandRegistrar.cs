using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;

namespace ZeroIssuesBot
{
    class CommandRegistrar
    {
        // establish an http client

        // get the requestUri

        // create a new request message of type post to request uri

        // get the JSON object for the command
        // add a new authentication header "Authorization": "Bearer abcdefg"
        // send the request

        public string AddApplicationCommand(HttpClient client, string command)
        {
            // Get resources from App.config
            var apiEndpoint = new Uri(ConfigurationManager.ConnectionStrings["apiEndpoint"].ToString());
            var clientId = ConfigurationManager.AppSettings["client_id"];
            var guildId = ConfigurationManager.ConnectionStrings["guildId"];

            // Get Uri for request and create new request with Uri
            Uri requestUri = new Uri($"{apiEndpoint}/applications/{clientId}/guilds/{guildId}/commands");
            var request = new HttpRequestMessage(HttpMethod.Post, requestUri);



            return "";
        }

        public List<SlashCommand> GetSlashCommands()
        {
            //read the commands.json file
            return new List<SlashCommand>();
        }
    }
}
