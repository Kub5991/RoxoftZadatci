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
    public class Program
    { 
        static void Main(string[] args)
        {
            
        }

        [TestFixture]
        public class NUnitTest1 :Base
        {
            [SetUp]
            public void Initialize()
            {
                driver.Navigate().GoToUrl("https://www.saucedemo.com/");
                Console.WriteLine("Opened URL");
            }
            [Test]
            public void Testiranje1()
            {
                //Test 1
                SeleniumSetMethods.FindText(driver, "user-name", "standard_user", "Name", "//*[@id='user-name']");
                Thread.Sleep(1000);
                SeleniumSetMethods.FindText(driver, "password", "secret_sauce", "Name", "//*[@id='password']");
                Thread.Sleep(1000);

                string xpathB = "//*[@id='login-button']";
                SeleniumSetMethods.FindButton(driver, "login-button", "Name", xpathB);
                Thread.Sleep(1000);

                xpathB ="//*[@id='react-burger-menu-btn']";
                SeleniumSetMethods.FindButton(driver, "react-burger-menu-btn", "Id", xpathB);
                Thread.Sleep(1000);

                xpathB = "//*[@id='about_sidebar_link']";
                SeleniumSetMethods.FindButton(driver, "about_sidebar_link", "Id", xpathB);
                Console.WriteLine("Clicked the about button!");
                Thread.Sleep(1000);

                driver.Navigate().Back();

                SeleniumSetMethods.FindButton(driver, "react-burger-menu-btn", "Id", "//*[@id='react-burger-menu-btn']");
                Thread.Sleep(1000);

                SeleniumSetMethods.FindButton(driver, "logout_sidebar_link", "Id", "//*[@id='logout_sidebar_link']");
                Thread.Sleep(1000);
            }
            [TearDown]
            public void CloseUp()
            {
                driver.Close();
                Console.WriteLine("Closing browser");
            }
        }

        [TestFixture]
        public class NUnitTest2 :Base
        {
            [SetUp]
            public void Initialize()
            {
                driver.Navigate().GoToUrl("https://www.saucedemo.com/");
                Console.WriteLine("Opened URL");
            }
            [Test]
            public void Testiranje2()
            {
                //Test 2
                SeleniumSetMethods.FindText(driver, "user-name", "", "Name", "//*[@id='user-name']");
                Thread.Sleep(1000);
                SeleniumSetMethods.FindText(driver, "password", "", "Name", "//*[@id='password']");
                Thread.Sleep(1000);

                string xpathB = "//*[@id='login-button']";
                SeleniumSetMethods.FindButton(driver, "login-button", "Name", xpathB);
                Thread.Sleep(1000);
                
                //Podtest1
                SeleniumSetMethods.FindText(driver, "user-name", "standard_user", "Name", "//*[@id='user-name']");
                Thread.Sleep(1000);
                SeleniumSetMethods.FindButton(driver, "login-button", "Name", xpathB);
                Thread.Sleep(1000);

                //Podtest2
                IWebElement element = driver.FindElement(By.XPath("//*[@id='user-name']"));
                element.Clear();
                SeleniumSetMethods.FindText(driver, "user-name", "", "Name", "//*[@id='user-name']");
                Thread.Sleep(1000);
                SeleniumSetMethods.FindText(driver, "password", "secret_sauce", "Name", "//*[@id='password']");
                Thread.Sleep(1000);
                SeleniumSetMethods.FindButton(driver, "login-button", "Name", xpathB);
                Thread.Sleep(1000);
            }
            [TearDown]
            public void CloseUp()
            {
                driver.Close();
                Console.WriteLine("Closing browser");
            }
        }
        [TestFixture]
        public class NUnitTest3 : Base
        {
            [SetUp]
            public void Initialize()
            {
                driver.Navigate().GoToUrl("https://www.saucedemo.com/");
                Console.WriteLine("Opened URL");
            }
            [Test]
            public void Testiranje3()
            {
                //Test 3
                SeleniumSetMethods.FindText(driver, "user-name", "locked_out_user", "Name", "//*[@id='user-name']");
                Console.WriteLine("Username: " + SeleniumGetMethods.GetText(driver, "user-name", "Id"));
                Thread.Sleep(1000);

                SeleniumSetMethods.FindText(driver, "password", "secret_sauce", "Name", "//*[@id='password']");
                Console.WriteLine("Password: " + SeleniumGetMethods.GetText(driver, "password", "Id"));
                Thread.Sleep(1000);

                string xpathB = "//*[@id='login-button']";
                SeleniumSetMethods.FindButton(driver, "login-button", "Name", xpathB);
                Thread.Sleep(1000);

                IWebElement element = driver.FindElement(By.XPath("//*[@id='user-name']"));
                element.Clear();
                Thread.Sleep(1000);
                IWebElement elem = driver.FindElement(By.XPath("//*[@id='password']"));
                elem.Clear();
                Thread.Sleep(1000);

                SeleniumSetMethods.FindText(driver, "user-name", "standard_user", "Name", "//*[@id='user-name']");
                Console.WriteLine("Username: " + SeleniumGetMethods.GetText(driver, "user-name", "Id"));
                Thread.Sleep(1000);

                SeleniumSetMethods.FindText(driver, "password", "secret_sauce", "Name", "//*[@id='password']");
                Console.WriteLine("Password: " + SeleniumGetMethods.GetText(driver, "password", "Id"));
                Thread.Sleep(1000);

                SeleniumSetMethods.FindButton(driver, "login-button", "Name", xpathB);
                Thread.Sleep(1000);

                SeleniumSetMethods.FindButton(driver, "add-to-cart-sauce-labs-backpack", "Id", "//*[@id='add-to-cart-sauce-labs-backpack']");
                Console.WriteLine("Clicked the ADD TO CART button!");
                Thread.Sleep(2000);

                SeleniumSetMethods.Click(driver, "shopping_cart_link", "class");
                Thread.Sleep(1000);
                Console.WriteLine("Clicked the shopping cart button!");
                Thread.Sleep(1000);

                IWebElement elemen = driver.FindElement(By.XPath("//*[@id='remove-sauce-labs-backpack']"));
                bool kupljen = false;
                kupljen = elemen.Displayed;
                if (kupljen == true)
                    Console.WriteLine("Product is in shopping cart");
            }
            [TearDown]
            public void CloseUp()
            {
                driver.Close();
                Console.WriteLine("Closing browser");
            }
        }       
    }
}
