using Newtonsoft.Json;

namespace ZeroIssuesBot
{
    public class Choice
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
