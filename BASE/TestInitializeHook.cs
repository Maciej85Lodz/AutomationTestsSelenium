using AutomationFramework.CONFIG;
using AutomationFramework.HELPERS;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace AutomationFramework.BASE
{

    public abstract class TestInitializeHook : Base
    {
        public readonly BrowserType Browser;

        public TestInitializeHook(BrowserType browser)
        {
            Browser = browser;
        }

        public void InitializeSettings()
        {
            //Set all settings for Framework
            ConfigReader.SetFrameworkSettings();

            //Set Log
            LogHelpers.CreateLogFile();

            //Open Browser
            OpenBrowser(Browser);

            LogHelpers.Write("The Framework has been initialized");
        }

        private void OpenBrowser(BrowserType browserType)
        {
            switch (browserType)
            {
                case
                    BrowserType.Chrome:
                    DriverContext.Driver = new ChromeDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                case
                    BrowserType.FireFox:
                    DriverContext.Driver = new FirefoxDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                default:
                    break;
            }
        }

        public virtual void NavigateSite()
        {
            DriverContext.Browser.GoToUrl(Settings.AUT);
            LogHelpers.Write("The Browser has been opened!");
        }
    }
}

