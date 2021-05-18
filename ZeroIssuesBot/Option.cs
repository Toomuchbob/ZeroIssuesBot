using Newtonsoft.Json;
using System.Collections.Generic;

namespace ZeroIssuesBot
{
    public class Option
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("required")]
        public string Required { get; set; }

        [JsonProperty("choices")]
        public List<Choice> Choices { get; set; }
    }
}
