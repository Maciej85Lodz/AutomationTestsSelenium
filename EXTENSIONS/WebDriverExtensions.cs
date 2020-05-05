using AutomationFramework.BASE;
using AutomationFramework.HELPERS;
using OpenQA.Selenium;
using System;
using System.Diagnostics;

namespace AutomationFramework.EXTENSIONS
{
    public static class WebDriverExtensions
    {
        public static void WaitForPageLoader(this IWebDriver driver)
        {
            driver.WaitForCondition(dri =>
            {
                string state = dri.ExecuteJs("return document.readyState").ToString();
                return state == "complete";
            }, 10);
        }

        public static void WaitForCondition<T>(this T obj, Func<T, bool> condition, int timeOut)
        {
            Func<T, bool> execute =
                (arg) =>
                {
                    try
                    {
                        return condition(arg);
                    }
                    catch (Exception e)
                    {
                        LogHelpers.Write("ERROR :: " + e.Message);
                        throw;
                    }
                };
            var stopWatching = Stopwatch.StartNew();
            while (stopWatching.ElapsedMilliseconds < timeOut)
            {
                if (execute(obj))
                {
                    break;
                }
            }
        }

        internal static object ExecuteJs(this IWebDriver driver, string script)
        {
            return ((IJavaScriptExecutor) DriverContext.Driver).ExecuteScript(script);
        }
    }
}
