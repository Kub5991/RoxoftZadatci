using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Selenium
{
    class SeleniumSetMethods
    {

        //EnterText metoda 
        public static void EnterText(IWebDriver driver, string element, string value, string elementtype)
        {
            if (elementtype == "Id")
                driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementtype == "Name")
                driver.FindElement(By.Name(element)).SendKeys(value);
        }

        //Click metoda
        public static void Click(IWebDriver driver, string element, string elementtype)
        {
            if (elementtype == "Id")
                driver.FindElement(By.Id(element)).Click();
            if (elementtype == "Name")
                driver.FindElement(By.Name(element)).Click();
            if (elementtype == "class")
                driver.FindElement(By.ClassName(element)).Click();
        }

        //FindButton metoda
        public static void FindButton(IWebDriver driver, string element, string elementtype, string xpathB)
        {
            bool Display=false;
            bool Enable=false;
            IWebElement ele = driver.FindElement(By.XPath(xpathB));
            Display = ele.Displayed;
            Enable = ele.Enabled;

            if (Display == true && Enable==true)
            {
                if (elementtype == "Id")
                    driver.FindElement(By.Id(element)).Click();
                if (elementtype == "Name")
                    driver.FindElement(By.Name(element)).Click();
                Console.WriteLine("Button " + element + " exists and is enabled");
            }
            else
                Console.WriteLine("Button  " + element + "  not enabled/ doesn't exist");
        }
        //FindText metoda
        public static void FindText(IWebDriver driver, string element, string value, string elementtype, string xpathT)
        {
            bool Display=false;
            bool Enable=false;
            IWebElement ele = driver.FindElement(By.XPath(xpathT));
            Display = ele.Displayed;
            Enable = ele.Enabled;
            
            if (Display == true && Enable == true)
            {
                if (String.IsNullOrEmpty(ele.GetAttribute("value")))
                {
                    if (elementtype == "Id")
                        driver.FindElement(By.Id(element)).SendKeys(value);
                    if (elementtype == "Name")
                        driver.FindElement(By.Id(element)).SendKeys(value);
                    Console.WriteLine("TextBox " + element + " exists and is enabled");
                }
            }
            else
                    Console.WriteLine("TextBox " + element + " not enabled/ doesn't exist");
        }
    }
}
