namespace MonopolyGame.Tests
{
    using System.Collections.Generic;
    using ArtOfTest.WebAii.Controls.HtmlControls;

    public class MonopolyGameMap : BaseElementMap
    {
        public HtmlListItem SettingsPageLink => this.Find.ByExpression<HtmlListItem>("id = RadTabStrip1,|, tagIndex = li:1");

        public HtmlInputText PlayersCount => this.Find.ById<HtmlInputText>("PlayerCount");

        public IList<HtmlInputText> AllPlayersNameInputs => this.Find.AllByExpression<HtmlInputText>("id=~PlayerName");

        public HtmlInputText MoneyForPlayer => this.Find.ById<HtmlInputText>("MoneyPerPlayer");

        public HtmlInputText MoneyInBank => this.Find.ById<HtmlInputText>("BankMoney");

        public HtmlDiv RollButton => this.Find.ByExpression<HtmlDiv>("TextContent=roll,tagname=div");

        public HtmlSpan ValidationError => this.Find.ById<HtmlSpan>("ValidationResult");
    }
}
