using System;
using System.Linq;


namespace MovieInfoApp
{
    class Startup
    {
        public static void Main()
        {

            var actor = MovieDb.GetActorInfoByName("Nell Tiger Free");
            var credits = MovieDb.GetTVCreditsByActorId(actor.Id);
            var creditsId = credits.Result.FirstOrDefault().CreditsId;
            var seriesInfo = MovieDb.GetTVSeriesDetailsByCreditsId(creditsId);

            MovieDb.Instance.Connect(new System.Net.Http.HttpClient(), new Uri("https://api.themoviedb.org/"), "8e44e41d1573ab3d390b11fc6d35d95e");


            Console.WriteLine(creditsId);
            Console.WriteLine(seriesInfo.Result.Episodes);
        }
    }
}
