using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

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
    public class Choice
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
