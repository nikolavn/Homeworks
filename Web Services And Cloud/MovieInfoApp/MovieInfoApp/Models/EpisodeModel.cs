namespace MovieInfoApp.Models
{
    using Newtonsoft.Json;

    public class EpisodeModel
    {
        [JsonProperty("episode_number")]
        public int EpisodeNumber { get; set; }

        [JsonProperty("season_number")]
        public int Season { get; set; }

        [JsonProperty("name")]
        public string EpisodeName { get; set; }
    }
}
