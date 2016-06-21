namespace MovieInfoApp.Models
{
    using Newtonsoft.Json;

    public class CreditsModel
    {
        [JsonProperty("credit_id")]
        public string CreditsId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("episode_count")]
        public int EpisodeCount { get; set; }
    }
}
