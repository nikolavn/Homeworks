namespace MovieInfoApp.Models
{
    using Newtonsoft.Json;

    public class SeriesSearchResults
    {
        [JsonProperty("media")]
        public SeriesInfo SeriesInfo { get; set; }
    }
}
