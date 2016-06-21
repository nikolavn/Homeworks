namespace MovieInfoApp.Models
{
    using Newtonsoft.Json;

    public class ActorModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
