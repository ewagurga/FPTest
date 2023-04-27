using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using OpenQA.Selenium.DevTools.V110.Emulation;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Configuration;

namespace FPTests
{
    [TestClass]
    public class FPTests
    {
        [TestMethod]
        public void TestDesktopResolution()

        {
            IWebDriver driver = new ChromeDriver();
            string url = "https://us.balmain.com/en/p/neoprene-and-leather-unicorn-low-top-sneakers-AM1VJ309KNLR0FA.html";
            driver.Navigate().GoToUrl(url);

            driver.Manage().Window.Maximize();

            IWebElement dismissButton = driver.FindElement(By.XPath("/html/body/div[7]/div/div/form/button[2]"));
            dismissButton.Click();

            IWebElement fitPredictor = driver.FindElement(By.ClassName("fp-element"));
            Assert.AreEqual(true, fitPredictor.Displayed);

            Thread.Sleep(3000);
            

        }



        [TestMethod]
        public void TestMobileResolution()
        {
            IWebDriver driver = new ChromeDriver();
            string url = "https://us.balmain.com/en/p/neoprene-and-leather-unicorn-low-top-sneakers-AM1VJ309KNLR0FA.html";
            driver.Navigate().GoToUrl(url);

            Console.WriteLine(driver.Manage().Window.Size);


            var deviceModeSetting = new SetDeviceMetricsOverrideCommandSettings();
            deviceModeSetting.Width = 600;
            deviceModeSetting.Height = 1000;
            deviceModeSetting.Mobile = true;
            deviceModeSetting.DeviceScaleFactor = 50;

            IWebElement dismissButton = driver.FindElement(By.XPath("/html/body/div[7]/div/div/form/button[2]"));
            dismissButton.Click();

            IWebElement fitPredictor = driver.FindElement(By.ClassName("fp-element"));
            Assert.AreEqual(true, fitPredictor.Displayed);

            Thread.Sleep(3000);

           
        }
        
        [TestMethod]
        public void AddCalculatorSeed()

        {
            IWebDriver driver = new ChromeDriver();
            string url = "https://us.balmain.com/en/p/neoprene-and-leather-unicorn-low-top-sneakers-AM1VJ309KNLR0FA.html";
            driver.Navigate().GoToUrl(url);

            IWebElement dismissButton = driver.FindElement(By.XPath("/html/body/div[7]/div/div/form/button[2]"));
            dismissButton.Click();

            IWebElement fitPredictor = driver.FindElement(By.ClassName("fp-element"));
            fitPredictor.Click();

            IWebElement shoeBrand = driver.FindElement(By.CssSelector("#js-attribute > div.fp-root.fp-site-language-en > div.fp-backdrop-container > div > div > div > div > div.fp-wizard-application > div > div.fp-inner > div.fp-calculator-form > div.fp-dropdown-container.fp-brand > select"));
            Thread.Sleep(2000);
            shoeBrand.Click();

          

        }

        
       


 

    }
    }

