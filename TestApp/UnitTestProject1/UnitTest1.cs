using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestApp;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        /*This is Assignment5*/

        [TestMethod]
        public void TestChromeDriver()
        {
            ChromeDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.facebook.com/login/");
            driver.FindElementById("email").SendKeys("az.sarajevo@gmail.com");
            driver.FindElementById("email").SendKeys(Keys.Tab);
            driver.FindElementById("pass").SendKeys("********");
            driver.FindElementById("pass").SendKeys(Keys.Tab);
            driver.FindElementById("loginbutton").SendKeys(Keys.Enter);
        }

        /*This is Lab10*/

        [TestMethod]
        public void TestMethod1()
        {
            bool result1 = Helper.IsPasswordOkay("1234");
            Assert.AreEqual(result1, false);
        }

        [TestMethod]
        public void TestMethod2()
        {
            bool result2 = Helper.IsMailOkay("amila_zimichotmail.com");
            Assert.AreEqual(result2, false);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string result3 = Helper.CalculateBamFromEur("25");
            Assert.AreEqual(result3, "48,89575");
        }

        [TestMethod]
        public void TestMethod4()
        {
            string result4 = Helper.CalculatePDV("100");
            Assert.AreEqual(result4, "17");
        }
    }
}
