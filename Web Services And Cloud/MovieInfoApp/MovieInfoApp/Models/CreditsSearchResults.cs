namespace MovieInfoApp.Models
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CreditsSearchResults
    {
        [JsonProperty("cast")]
        public List<CreditsModel> Credits { get; set; }
    }
}
