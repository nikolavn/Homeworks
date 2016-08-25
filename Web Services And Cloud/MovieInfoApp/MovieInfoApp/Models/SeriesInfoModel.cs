namespace MovieInfoApp.Models
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public class SeriesInfoModel
    {
        [JsonProperty("episodes")]
        public List<EpisodeModel> Episodes { get; set; }

        [JsonProperty("seasons")]
        public List<SeasonModel> Seasons { get; set; }
    }
}
