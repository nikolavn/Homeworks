namespace MovieInfoApp.Models
{
    using Newtonsoft.Json;

    public class SeasonModel
    {
        [JsonProperty("season_number")]
        public int SeasonNumber { get; set; }
    }
}