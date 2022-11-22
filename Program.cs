using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            // create referance for browser
            IWebDriver driver = new ChromeDriver();

            // navigate to google page
            driver.Navigate().GoToUrl("http://www.amazon.in");

            IWebElement element = driver.FindElement(By.Id("twotabsearchtextbox"));

            //perform Ops
            element.SendKeys("Painting");

            IWebElement element1 = driver.FindElement(By.Id("nav-search-submit-button"));

           element1.Click();

            driver.Close();
        }
    }
}
