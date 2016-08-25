namespace MovieInfoApp.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class ActorSearchResultsModel
    {
        [JsonProperty("results")]
        public List<ActorModel> Results { get; set; }
    }
}
