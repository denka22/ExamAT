using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support;
using System;
using System.IO;
using System.Linq;
using System.Threading;

namespace Task1
{
    public class Tests
    {

        IWebDriver driver;
        [OneTimeSetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(" https://auchan.zakaz.ua/en/");
            driver.Manage().Window.Maximize();
            
        }

        [Test]
        public void Test1()
        {
            var marketbutton = driver.FindElement(By.XPath("/html/body/div[1]/header/div[1]/div[1]/div/div/div[2]/div/div/span[2]"));
            marketbutton.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            var Choselist = driver.FindElement(By.CssSelector("#react-tabs-1 > div > div > div > div > div.RegionSelect__indicators.css-1wy0on6 > div"));
            Choselist.Click();
            
            
          
            var ChoseLviv = driver.FindElement(By.Id("react-select-2-option-3"));
            ChoseLviv.Click();
            
            var deliveryField = driver.FindElement(By.CssSelector("#react-tabs-1 > div > div.jsx-2152023046.CourierDeliveryInfo__chooseMapPoint > button > span"));
            deliveryField.Click();
            var findme = driver.FindElement(By.CssSelector("body > div.ReactModalPortal > div > div > div.jsx-385435685.general-modal__body-wrapper > div > div.jsx-2181983899.MapModal__bottomControls > div.jsx-2181983899.MapModal__getPositionMainButtonContainer > div > button"));
            findme.Click();
            var toshop = driver.FindElement(By.CssSelector("body > div.ReactModalPortal > div > div > div.jsx-385435685.general-modal__body-wrapper > div > div.jsx-2181983899.MapModal__bottomControls > div.jsx-2181983899.MapModal__getPositionMainButtonContainer > button"));
            toshop.Click();
            var searchField = driver.FindElement(By.XPath("/html/body/div[1]/header/div[1]/div[2]/div/div/div[2]/div/input"));
            searchField.SendKeys("манго");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            var mango = driver.FindElement(By.XPath("/html/body/div[1]/header/div[1]/div[2]/div/div/div[2]/div/div[4]/div/div/ul/li[1]/div/div[1]/a"));
            mango.Click();

            var mangoItemPrice = driver.FindElement(By.XPath("/html/body/div[6]/div/div/div[1]/div/div[3]/div[2]/div[1]/div[2]/h6/span[1]")).Text;

            Console.WriteLine("price=" + mangoItemPrice);
            mangoItemPrice = mangoItemPrice.Substring(0, mangoItemPrice.Length - 1);
            Console.WriteLine("price=" + mangoItemPrice);
           

            double temp = double.Parse(mangoItemPrice);
            Console.WriteLine("price=" + temp);

            Assert.AreEqual(temp, 22.0);








        }
    }
}