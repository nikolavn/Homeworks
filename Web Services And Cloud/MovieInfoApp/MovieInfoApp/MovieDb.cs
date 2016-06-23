namespace MovieInfoApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Net.Http.Headers;

    using Newtonsoft.Json;
    using Models;
    using System.Threading.Tasks;

    public static class MovieDb
    {
        private static readonly Uri BaseUrl = new Uri("https://api.themoviedb.org/");
        private static readonly string PeopleEndpoint = "3/search/person";
        private static readonly string TVCreditsEndpointFormat = "3/person/{0}/tv_credits";
        private static readonly string CreditDetailsEndpointFormat = "3/credit/{0}";
        private const string ApiKey = "8e44e41d1573ab3d390b11fc6d35d95e";


        public static async Task<ActorModel> GetActorInfoByName(string name)
        {
            string responseData;
            string nameQuery = "query=" + Uri.EscapeUriString(name);

            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var targetUrl = CreateUrl(BaseUrl, PeopleEndpoint);

            targetUrl.Query = targetUrl.Query.Substring(1) + "&" + nameQuery;

            client.BaseAddress = targetUrl.Uri;

            Task<string> response = client.GetStringAsync("");
            responseData = await response;

            var actors = JsonConvert.DeserializeObject<ActorSearchResults>(responseData);

            return actors.Results.FirstOrDefault();
        }

        public static async Task<List<CreditsModel>> GetTVCreditsByActorId(int actorId)
        {
            string responseData;
            var endPointWithActorId = string.Format(TVCreditsEndpointFormat, actorId);

            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var targetUrl = CreateUrl(BaseUrl, endPointWithActorId);
            client.BaseAddress = targetUrl.Uri;

            Task<string> response = client.GetStringAsync("");
            responseData = await response;

            var credits = JsonConvert.DeserializeObject<CreditsSearchResults>(responseData);

            return credits.Credits;
        }

        public static async Task<SeriesInfo> GetTVSeriesDetailsByCreditsId(string creditsId)
        {
            string responseData;

            var endPointWithCreditsId = string.Format(CreditDetailsEndpointFormat, creditsId);

            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var targetUrl = CreateUrl(BaseUrl, endPointWithCreditsId);
            client.BaseAddress = targetUrl.Uri;

            var response = client.GetStringAsync("");
            responseData = await response;

            var result = JsonConvert.DeserializeObject<SeriesSearchResults>(responseData);

            return result.SeriesInfo;
        }

        private static UriBuilder CreateUrl(Uri baseUrl, string endpoint)
        {
            UriBuilder targetUrl = new UriBuilder(baseUrl);

            targetUrl.Path = endpoint;
            targetUrl.Query = "api_key=" + ApiKey;

            return targetUrl;
        }
    }
}
