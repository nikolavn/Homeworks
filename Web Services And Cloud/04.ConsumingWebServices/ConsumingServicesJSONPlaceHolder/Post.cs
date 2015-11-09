namespace ConsumingServicesJSONPlaceHolder
{
    using Newtonsoft.Json;

    public class Post
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }
    }
}
