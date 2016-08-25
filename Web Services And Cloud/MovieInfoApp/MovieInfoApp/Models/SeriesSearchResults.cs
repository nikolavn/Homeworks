namespace MovieInfoApp.Models
{
    using Newtonsoft.Json;

    public class SeriesSearchResults
    {
        [JsonProperty("media")]
        public SeriesInfoModel SeriesInfo { get; set; }
    }
}
