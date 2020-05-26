using System;
using System.IO;
using System.Xml.XPath;
using AutomationFramework.BASE;
using AutomationFramework.ConfigElement;

namespace AutomationFramework.CONFIG
{
    public class ConfigReader
    {
        //public static void SetFrameworkSettings()
        //{
        //    XPathItem aut;
        //    XPathItem testType;
        //    XPathItem isLog;
        //    XPathItem isReport;
        //    XPathItem buildName;
        //    XPathItem logPath;
        //    XPathItem appConnection;
        //    XPathItem browserType;

        //    string strFileName = Environment.CurrentDirectory.ToString() + "\\Config\\GlobalConfig.xml";
        //    FileStream stream = new FileStream(strFileName,FileMode.Open);
        //    XPathDocument document = new XPathDocument(stream);
        //    XPathNavigator navigator = document.CreateNavigator();

        //    //Get XML Details and pass it in XPathItem type variables
        //    aut = navigator.SelectSingleNode("AutomationFramework/RunSettings/AUT"); // AUT => webApplication; AUT2 => localhost;
        //    testType = navigator.SelectSingleNode("AutomationFramework/RunSettings/TestType");
        //    isLog = navigator.SelectSingleNode("AutomationFramework/RunSettings/IsLog");
        //    isReport = navigator.SelectSingleNode("AutomationFramework/RunSettings/IsReport");
        //    buildName = navigator.SelectSingleNode("AutomationFramework/RunSettings/BuildName");
        //    logPath = navigator.SelectSingleNode("AutomationFramework/RunSettings/LogPath");
        //    appConnection = navigator.SelectSingleNode("AutomationFramework/RunSettings/ApplicationDb");
        //    browserType = navigator.SelectSingleNode("AutomationFramework/RunSettings/Browser");
        //    //Set XML Details in the property to be used accross framework
        //    Settings.AUT = aut.Value;
        //    Settings.TestType = testType.Value.ToString();
        //    Settings.IsLog = isLog.Value.ToString();
        //    Settings.IsReporting = isReport.Value.ToString();
        //    Settings.BuildName = buildName.Value.ToString();
        //    Settings.LogPath = logPath.Value.ToString();
        //    Settings.AppConnectionString = appConnection.Value.ToString();
        //    Settings.BrowserType = (BrowserType)Enum.Parse(typeof(BrowserType), browserType.Value.ToString());
        //}
        public static void SetFrameworkSettings()
        {
            Settings.AUT = EATestConfiguration.EASettings.TestSettings["staging"].AUT;
            //Settings.BuildName = buildname.Value.ToString();
            Settings.TestType = EATestConfiguration.EASettings.TestSettings["staging"].TestType;
            Settings.IsLog = EATestConfiguration.EASettings.TestSettings["staging"].IsLog;
            //Settings.IsReporting = EATestConfiguration.EASettings.TestSettings["staging"].IsReadOnly;
            Settings.LogPath = EATestConfiguration.EASettings.TestSettings["staging"].LogPath;
            //Settings.AppConnectionString = appConnection.Value.ToString();
            Settings.BrowserType = (BrowserType)Enum.Parse(typeof(BrowserType), EATestConfiguration.EASettings.TestSettings["staging"].Browser);
        }
    }
}
