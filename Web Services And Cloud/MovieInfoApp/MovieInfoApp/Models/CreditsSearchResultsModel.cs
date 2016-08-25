namespace MovieInfoApp.Models
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CreditsSearchResultsModel
    {
        [JsonProperty("cast")]
        public List<CreditsModel> Credits { get; set; }
    }
}
