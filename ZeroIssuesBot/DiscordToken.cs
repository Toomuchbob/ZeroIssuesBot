using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZeroIssuesBot
{
    class DiscordToken
    {
        public string access_token { get; set; }
        public int expires_in { get; set; }
        public string scope { get; set; }
        public string token_type { get; set; }

        public static DiscordToken GetTokenFromResponse(string responseString)
        {
            return JsonConvert.DeserializeObject<DiscordToken>(responseString);
        }
    }
}
