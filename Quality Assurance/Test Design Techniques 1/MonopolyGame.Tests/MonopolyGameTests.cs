using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace MonopolyGame.Tests
{
    using ArtOfTest.WebAii.Core;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MonopolyGameTests : BaseTest
    {
        private const string MonopolyGameUrl = "http://localhost:49573/Default.aspx";
        private const double ExpectedBankMoney6Players1499 = 3000.06;
        private const string ValidNumberOfPlayers = "4";

        public MonopolyGameMap GameMap { get; set; }

        public override void TestInit()
        {
            this.GameMap = new MonopolyGameMap();
        }

        [TestCleanup]
        public void TeardownTest()
        {
            Manager.Current.ActiveBrowser.Close();
        }

        [TestMethod]
        public void StartGameWithValidNumberOfPlayersAndValidAMountOfMoneyWorks()
        {
            this.Browser.NavigateTo(MonopolyGameUrl);

            this.GameMap.SettingsPageLink.MouseClick();
            this.GameMap.PlayersCount.Text = "2";
            this.GameMap.AllPlayersNameInputs[0].Text = "Pesho";
            this.GameMap.AllPlayersNameInputs[1].Text = "Gosho";
            this.GameMap.MoneyForPlayer.Text = "1300";

            Assert.IsFalse(this.GameMap.ValidationError.IsVisible());
        }

        [TestMethod]
        public void PlayerNameFiledsCorrespondToTheNumberChosenInPlayersCount()
        {
            this.Browser.NavigateTo(MonopolyGameUrl);

            this.GameMap.SettingsPageLink.MouseClick();
            this.GameMap.PlayersCount.Text = ValidNumberOfPlayers;

            Assert.AreEqual(int.Parse(ValidNumberOfPlayers), this.GameMap.AllPlayersNameInputs.Count);
        }

        [TestMethod]
        public void EnteringPlayerNameContainingANumberProducesAnError()
        {
            this.Browser.NavigateTo(MonopolyGameUrl);

            this.GameMap.SettingsPageLink.MouseClick();
            this.GameMap.PlayersCount.Text = "2";
            this.GameMap.AllPlayersNameInputs[0].Text = "Pesho1";
            this.GameMap.AllPlayersNameInputs[1].Text = "Gosho";
            this.GameMap.MoneyForPlayer.Text = "1300";

            Assert.IsTrue(this.GameMap.ValidationError.IsVisible());
        }

        [TestMethod]
        public void Entering3InPlayersCountFieldThrowsAnException()
        {
            this.Browser.NavigateTo(MonopolyGameUrl);

            this.GameMap.SettingsPageLink.MouseClick();
            this.GameMap.PlayersCount.Text = "3";

            var dialogsCount = Manager.Current.DialogMonitor.Dialogs.Count;

            Assert.IsTrue(dialogsCount > 0);
        }

        [TestMethod]
        public void EnteringValidValueForMoneyPerPlayerShouldCalculateBankCorrectly()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            this.Browser.NavigateTo(MonopolyGameUrl);

            this.GameMap.SettingsPageLink.MouseClick();
            this.GameMap.PlayersCount.Text = "6";
            this.GameMap.MoneyForPlayer.Text = "1499,99";

            var calculatedBank = double.Parse(this.GameMap.MoneyInBank.Value);

            Assert.AreEqual(ExpectedBankMoney6Players1499, calculatedBank);
        }
    }
}
