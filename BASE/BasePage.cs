using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutomationFramework.BASE
{
    public abstract class BasePage
    {
        public BasePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver,this);
        }
    }
}
