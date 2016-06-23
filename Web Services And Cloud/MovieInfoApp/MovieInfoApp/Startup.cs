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

            Console.WriteLine(creditsId);
            Console.WriteLine(seriesInfo.Result.Episodes);
        }
    }
}
