namespace MovieInfo.Tests
{
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using MovieInfoApp;
    using MovieInfoApp.Models;

    [TestClass]
    public class ActorTests
    {
        private static ActorModel actorInfo;
        private static CreditsModel credits;
        private static string creditsId;
        private static SeriesInfoModel seriesInfo;
        private static List<EpisodeModel> episodes;
        private static List<SeasonModel> seasons;

        [ClassInitialize]
        public static void InitializeData(TestContext context)
        {
            GetData();
        }

        //In Game of Thrones Nell Tiger Free plays Myrcella Baratheon, write a test to verify the following;

        [TestMethod]
        public void ActorIsNotInSeason6Episode1()
        {
            Assert.IsFalse(episodes.Any(e => e.Season == 6 && e.EpisodeNumber == 1));
        }

        [TestMethod]
        public void ActorIsInSeason5Episode1AsMainCastMemberButNotAsGuest()
        {
            Assert.IsTrue(seasons.Any(s => s.SeasonNumber == 5));
            Assert.IsFalse(episodes.Any(e => e.Season == 5 && e.EpisodeNumber == 1));
        }

        [TestMethod]
        public void ActorIsInSeason5Episode2AsMainCastMemberAndAsGuest()
        {
            Assert.IsTrue(seasons.Any(s => s.SeasonNumber == 5));
            Assert.IsTrue(episodes.Any(e => e.Season == 5 && e.EpisodeNumber == 2));
        }

        private static void GetData()
        {
            actorInfo = MovieDb.GetActorInfoByName("Nell Tiger Free").Result;
            credits = MovieDb.GetTVCreditsByActorId(actorInfo.Id).Result.FirstOrDefault();
            creditsId = credits.CreditsId;
            seriesInfo = MovieDb.GetTVSeriesDetailsByCreditsId(creditsId).Result;
            episodes = seriesInfo.Episodes;
            seasons = seriesInfo.Seasons;
        }
    }
}
