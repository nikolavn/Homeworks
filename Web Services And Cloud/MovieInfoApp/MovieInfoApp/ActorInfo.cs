namespace MovieInfoApp
{
    using System;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Models;
    using Newtonsoft.Json;

    public class ActorInfo
    {
        private static ActorInfo retrieve;

        private ActorInfo(HttpClient client, string endpoint)
        {
            this.PrepareEndpoint(client, endpoint);
        }

        public static async Task<ActorModel> GetActorInfoByName(HttpClient client,string actorName)
        {
            string responseData;
            string escapedName = Uri.EscapeUriString(actorName);
            
            client.BaseAddress = client.BaseAddress.AddParameter("query", escapedName);

            Task<string> response = client.GetStringAsync("");
            responseData = await response;

            var actors = JsonConvert.DeserializeObject<ActorSearchResultsModel>(responseData);

            return actors.Results.FirstOrDefault();
        }

        private Uri PrepareEndpoint(HttpClient client, string endpoint)
        {
            UriBuilder targetUrl = new UriBuilder(client.BaseAddress);
            targetUrl.Path = endpoint;

            client.BaseAddress = targetUrl.Uri;

            return targetUrl.Uri;
        }
    }
}
