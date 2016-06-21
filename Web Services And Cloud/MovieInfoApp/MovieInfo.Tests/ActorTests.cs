using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace MovieInfo.Tests
{
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using MovieInfoApp;
    [TestClass]
    public class ActorTests
    {
        //In Game of Thrones Nell Tiger Free plays Myrcella Baratheon, write a test to verify the following;

        [TestMethod]
        public void ActorIsNotInSeason6Episode1()
        {
            var actorInfo = MovieDb.GetActorInfoByName("Nell Tiger Free");
            var credits = MovieDb.GetTVCreditsByActorId(actorInfo.Id);
            var creditsId = credits.FirstOrDefault().CreditsId;
            var seriesInfo = MovieDb.GetTVSeriesDetailsByCreditsId(creditsId);

            Assert.IsFalse(seriesInfo.Episodes.Any(e => e.Season == 6 && e.EpisodeNumber == 1));
        }

        [TestMethod]
        public void ActorIsInSeason5Episode1AsMainCastMemberButNotAsGuest()
        {
            var actorInfo = MovieDb.GetActorInfoByName("Nell Tiger Free");
            var credits = MovieDb.GetTVCreditsByActorId(actorInfo.Id);
            var creditsId = credits.FirstOrDefault().CreditsId;
            var seriesInfo = MovieDb.GetTVSeriesDetailsByCreditsId(creditsId);

            Assert.IsTrue(seriesInfo.Seasons.Any(s => s.SeasonNumber == 5));
            Assert.IsFalse(seriesInfo.Episodes.Any(e => e.Season == 5 && e.EpisodeNumber == 1));
        }

        [TestMethod]
        public void ActorIsInSeason5Episode2AsMainCastMemberAndAsGuest()
        {
            var actorInfo = MovieDb.GetActorInfoByName("Nell Tiger Free");
            var credits = MovieDb.GetTVCreditsByActorId(actorInfo.Id);
            var creditsId = credits.FirstOrDefault().CreditsId;
            var seriesInfo = MovieDb.GetTVSeriesDetailsByCreditsId(creditsId);

            Assert.IsTrue(seriesInfo.Seasons.Any(s => s.SeasonNumber == 5));
            Assert.IsTrue(seriesInfo.Episodes.Any(e => e.Season == 5 && e.EpisodeNumber == 2));
        }
    }
}
