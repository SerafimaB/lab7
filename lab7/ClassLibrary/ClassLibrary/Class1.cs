using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ClassLibrary
{
    public class Class1
    {
        IWebDriver webDriver = new ChromeDriver();
        [TestCase]
        public void maintTitle()
        {
        webDriver.Url = "https://sibsutis.ru/";
            Assert.AreEqual("Сибирский государственный университет телекоммуникаций и информатики", webDriver.Title);
            webDriver.Close();
        }


    

         [TestCase]
         public void obj()
        {
            webDriver.Url = "https://sibsutis.ru/";
           
            IWebElement element = webDriver.FindElement(By.XPath("//*[@id=\"qqq\"]"));
            bool status = element.Displayed;

          
        }

        [TestCase]
        public void ssilka()
        {
            webDriver.Url = "https://sibsutis.ru/";
            IWebElement element = webDriver.FindElement(By.XPath("//*[@id=\"mainMenu\"]/a[1]"));
            element.Click();



        }

        [TestCase]
        public void pole()
        {
            webDriver.Url = "https://sibsutis.ru/";
            IWebElement search = webDriver.FindElement(By.XPath("//*[@id=\"qqq\"]"));
            search.SendKeys("");


        }

        [TestCase]
        public void knopka()
        {
            webDriver.Url = "https://sibsutis.ru/";
            IWebElement button = webDriver.FindElement(By.XPath("//*[@id=\"layout\"]/div[2]/div[2]/div[2]/div[3]/form/input[2]"));
            button.Click();
            



        }

        [TearDown]
        public void end()
        {
            webDriver.Quit();
            
        }


    }
}
