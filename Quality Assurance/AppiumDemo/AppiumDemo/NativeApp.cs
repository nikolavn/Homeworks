namespace AppiumDemo
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using OpenQA.Selenium.Appium;
    using OpenQA.Selenium.Remote;
    using OpenQA.Selenium.Appium.Android;
    using System.IO;
    using System.Collections.ObjectModel;
    using OpenQA.Selenium.Appium.Service;
    using OpenQA.Selenium.Appium.Service.Options;
    using OpenQA.Selenium;

    [TestClass]
    public class NativeApp
    {
        private const string TestHeight = "201";
        private const string TestWeight = "153";
        private const string TestName = "Bai Ivan";

        private static AppiumLocalService service;
        private static AppiumDriver<AndroidElement> driver;

        //private TestContext testContextInstance;

        //public TestContext TestContext
        //{
        //    get
        //    {
        //        return testContextInstance;
        //    }
        //    set
        //    {
        //        testContextInstance = value;
        //    }
        //}

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            //Start Appium Server
           var avdOptions = new KeyValuePair<string, string>("--avd", "Api19");
            //var avdParamsOptions = new KeyValuePair<string, string>("--avd-args", "\"-scale 0.50\"");
            OptionCollector args = new OptionCollector();
            args.AddArguments(avdOptions);
            //args.AddArguments(avdParamsOptions);

            var platform = Platform.CurrentPlatform;

            service = new AppiumServiceBuilder()
                .WithAppiumJS(new FileInfo(@"C:\Users\Asus\AppData\Roaming\npm\node_modules\appium\bin\appium.js"))
                .UsingDriverExecutable(new FileInfo(@"C:\Program Files\nodejs\node.exe"))
                .WithArguments(args)
                .UsingPort(4723)
                .Build();


            service.Start();
            Assert.IsTrue(service.IsRunning);

            // Start Appium Client
            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability("deviceName", "Api19");
            capabilities.SetCapability("platformName", "Android");
            capabilities.SetCapability("app", @"D:\fitness.apk");
            driver = new AndroidDriver<AndroidElement>(service.ServiceUrl, capabilities, TimeSpan.FromSeconds(60));
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            driver.Quit();
            service.Dispose();
        }

        [TestInitialize]
        public void TestInit()
        {
            driver.ResetApp();
        }

        [TestCleanup]
        public void TestCleanup()
        {
        }
        
        private static AndroidElement Slider => driver.FindElementByClassName("android.widget.SeekBar");

        private static AndroidElement Name => driver.FindElementByClassName("android.widget.Button");

        private static ReadOnlyCollection<AndroidElement> NotificationSwitches => driver.FindElementsByClassName("android.widget.Switch");

        private static ReadOnlyCollection<AndroidElement> ProfileDetails => driver.FindElementsByClassName("android.widget.EditText");       


        enum Directions { Up, Down };

        private static void Swipe(Directions direction)
        {
            var height = driver.Manage().Window.Size.Height;
            var width = driver.Manage().Window.Size.Width;

            int startX = width / 2;
            int startY = height / 2;
            int endX = width / 2;
            int endY = height / 2;

            if (direction == Directions.Down)
            {
                startY = Convert.ToInt32(height * 0.75);
                endY = Convert.ToInt32(height * 0.25);
            }
            else if (direction == Directions.Up)
            {
                startY = Convert.ToInt32(height * 0.25);
                endY = Convert.ToInt32(height * 0.75);
            }

            driver.Swipe(startX, startY, endX, endY, 1000);
        }

        [TestMethod]
        public void TurnSwitchesToOff()
        {
            foreach (var sw in NotificationSwitches)
            {
                if (sw.Text == "ON")
                {
                    sw.Click();
                }
            }

            Assert.IsFalse(Slider.Enabled);
        }

        [TestMethod]
        public void EditHeightAndWeight()
        {
            ProfileDetails[0].Click();
            driver.Keyboard.SendKeys(TestHeight);
            ProfileDetails[1].Click();
            driver.Keyboard.SendKeys(TestWeight);
            driver.BackgroundApp(10);

            Assert.AreEqual(TestHeight, ProfileDetails[0].Text);
            Assert.AreEqual(TestWeight, ProfileDetails[1].Text);
        }

        [TestMethod]
        public void EditName()
        {
            Name.Click();
            driver.Keyboard.SendKeys(TestName);
            driver.BackgroundApp(10);

            Assert.AreEqual(TestName, Name.Text);
        }
    }
}
