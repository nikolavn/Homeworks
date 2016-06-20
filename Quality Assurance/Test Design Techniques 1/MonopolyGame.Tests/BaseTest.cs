
namespace MonopolyGame.Tests
{
    using ArtOfTest.WebAii.Core;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class BaseTest
    {
        public Browser Browser => Manager.Current.ActiveBrowser;

        public virtual void TestInit()
        {
        }

        public virtual void TestCleanUp()
        {
        }

        [TestInitialize]
        public void CoreTestInit()
        {
            this.TestInit();
            this.InitializeBrowser();
            this.ClearBrowserCache();
        }

        [TestCleanup]
        public void CoreCleanUp()
        {
            this.TestCleanUp();
            this.CleanUp();
        }

        private void CleanUp()
        {
            if (Manager.Current == null)
            {
                return;
            }

            if (Manager.Current.Settings.Web.RecycleBrowser)
            {
                return;
            }

            Manager.Current.Dispose();
        }

        [ClassCleanup]
        public void CoreClassCleanUp()
        {
            this.Shutdown();
        }

        private void Shutdown()
        {
            if (Manager.Current == null || !Manager.Current.Settings.Web.RecycleBrowser)
            {
                return;
            }

            Manager.Current.ActiveBrowser.Close();
            Manager.Current.Dispose();
        }

        private void InitializeBrowser()
        {
            if (Manager.Current == null)
            {
                var settings = new Settings
                {
                    ClientReadyTimeout = 60000,
                    ExecuteCommandTimeout = 60000,
                    ElementWaitTimeout = 30000,
                    ExecutionDelay = 100,
                    AnnotateExecution = true,
                    Web =
                    {
                        DefaultBrowser = BrowserType.InternetExplorer,
                        RecycleBrowser = true
                    }
                };

                var manager = new Manager(settings);
                manager.Start();
            }

            Manager.Current.LaunchNewBrowser();
            Manager.Current.ActiveBrowser.Window.Maximize();
        }

        private void ClearBrowserCache()
        {
            this.Browser.ClearCache(BrowserCacheType.Cookies);
            this.Browser.ClearCache(BrowserCacheType.History);
            this.Browser.ClearCache(BrowserCacheType.TempFilesCache);
        }
    }
}
