using AutomationFramework.CONFIG;
using System;
using System.IO;

namespace AutomationFramework.HELPERS
{
    public class LogHelpers
    {
        //Global Declaration
        private static string _logFileName = string.Format("{0:yyyymmddhhmmss}", DateTime.Now);
        private static StreamWriter _streamer = null;

        //Create a file which can store the log information
        public static void CreateLogFile()
        {
            //string dir = @"D:\PROGRAMOWANIE\REPOZYTORIA\AutomationTestSeleniumC#\AutomationTestsSelenium\LOGS\";
            string dir = Settings.LogPath;
            if (Directory.Exists(dir))
            {
                _streamer = File.AppendText(dir + _logFileName + ".log");
            }
            else
            {
                Directory.CreateDirectory(dir);
                _streamer = File.AppendText(dir + _logFileName + ".log");
            }
        }



        //Create a method which can write the text in the log file
        public static void Write(string logMessage)
        {
            _streamer.Write("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            _streamer.WriteLine("    {0}", logMessage);
            _streamer.Flush();
        }


    }
}
