using Newtonsoft.Json;
using System.Collections.Generic;

namespace ZeroIssuesBot
{
    class SlashCommand
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("options")]
        public List<Option> Options { get; set; }
    }
}
