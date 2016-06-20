namespace MovieInfoApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Threading.Tasks;

    public class MovieDb
    {
        private static readonly Uri BaseUrl = new Uri("https://api.themoviedb.org/3/search/person");
        private const string ApiKey = "xxx";

        public static void Main()
        {
            var client = new HttpClient();

            var result = GetActorInfoByName(client, "bruce willis");

            Console.WriteLine();
        }

        private static string GetActorInfoByName(HttpClient client, string name)
        {
            string responseData;
            var test = Uri.EscapeUriString(name);
            string nameQuery = "query=" + Uri.EscapeUriString(name);
            UriBuilder targetUrl = new UriBuilder(BaseUrl);

            targetUrl.Query = "api_key=" + ApiKey;
            targetUrl.Query = targetUrl.Query.Substring(1) + "&" + nameQuery;

            client.BaseAddress = targetUrl.Uri;
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = client.GetAsync("").Result;
            responseData = response.Content.ReadAsStringAsync().Result;

            return responseData;
        }
    }
}
