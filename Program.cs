using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealer_Portal
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://covercheck.vwfsinsuranceportal.co.uk");
            IWebElement element = driver.FindElement(By.Name("vehicleReg"));
            element.SendKeys("OV12UYY");
            element = driver.FindElement(By.Name("btnfind"));
            element.Click();
        }
    }
}
