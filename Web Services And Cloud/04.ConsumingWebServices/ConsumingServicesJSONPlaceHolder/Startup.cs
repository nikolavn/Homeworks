namespace ConsumingServicesJSONPlaceHolder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Net.Http.Headers;

    using Newtonsoft.Json;

    class Startup
    {
        private const string DefaultUri = "http://jsonplaceholder.typicode.com/posts";

        static void Main()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(DefaultUri);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            Console.WriteLine("Enter search phrase or enter for default (lor): ");
            var phrase = Console.ReadLine();
            if (string.IsNullOrEmpty(phrase))
            {
                phrase = "lor";
            }

            Console.WriteLine("Enter number of posts or enter for default(10): ");
            int numberOfPosts;
            if (!int.TryParse(Console.ReadLine(), out numberOfPosts))
            {
                numberOfPosts = 10;
            }

            var posts = GetPosts(client, phrase, numberOfPosts);

            Console.WriteLine("{0} post(s) with title containing {1}: " + Environment.NewLine, numberOfPosts, phrase);

            foreach (var post in posts)
            {
                Console.WriteLine("Title: {0}", post.Title);
                Console.WriteLine("Content: {0}", post.Body);
                Console.WriteLine();
            }
        }

        private static ICollection<Post> GetPosts(HttpClient client, string postTitle, int postsCount)
        {
            HttpResponseMessage response = client.GetAsync("").Result;

            var allPostsJson = response.Content.ReadAsStringAsync().Result;
            var allPosts = JsonConvert.DeserializeObject<List<Post>>(allPostsJson);

            var filtered = allPosts
                .Where(p => p.Title.Contains(postTitle))
                .Take(postsCount)
                .ToList();

            return filtered;
        }
    }
}
