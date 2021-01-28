using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support;
using System;
using System.IO;
using System.Linq;
using System.Threading;

namespace Task2
{
    public class Tests
    {
        IWebDriver driver;
        [OneTimeSetUp]
        
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://ctflearn.com/challenge/1/browse");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {

            var loginbut = driver.FindElement(By.XPath("/html/body/nav/div[2]/ul/li/a"));
            loginbut.Click();
            var Emailfield = driver.FindElement(By.CssSelector("#identifier"));
            Emailfield.SendKeys("ivanyshyndenys@gmail.com");
            var Pasword = driver.FindElement(By.CssSelector("#password"));
            Pasword.SendKeys("qwerty123");
            var Log = driver.FindElement(By.XPath("/html/body/div/div/div/div/div[1]/div[2]/form/button"));
            Log.Click();
            var chalanges = driver.FindElement(By.XPath("/html/body/nav/div[2]/ul/li[2]/a[1]"));
            chalanges.Click();
            System.Threading.Thread.Sleep(6000);
            var searchField = driver.FindElement(By.CssSelector("#search"));
            searchField.SendKeys("Scope");
            System.Threading.Thread.Sleep(3000);
            var SCOPE = driver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div/div[1]"));
            SCOPE.Click();
            var DownloadClick = driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[1]/div/div/div[2]/div[1]/div/a"));
            DownloadClick.Click();
            var Flag = driver.FindElement(By.CssSelector("#inlineFormInputGroup"));
            Flag.SendKeys("123");
            var Submit = driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[1]/div/div/div[2]/div[2]/div/div/div[2]/button"));
            Submit.Click();
            try
             {
                //if we can find it means that popup was shown
                System.Threading.Thread.Sleep(1000);
                var popup = driver.FindElement(By.CssSelector("#toast-1"));
                Assert.Pass();
            }
            catch(OpenQA.Selenium.NoSuchElementException) {
                //if we can't find it means that popup wasn't shown
                Assert.Fail();
             }
           
               
            
            
        }
    }
}