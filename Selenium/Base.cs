using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Selenium
{
    [TestFixture]
    public class Base
    {
        public IWebDriver driver = new FirefoxDriver();
    }
}
