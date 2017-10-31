using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumTest
{ 

         enum PropertyType
         {
            Id,
            Name,
            LinkText,
            CssName,
            XPath,
            ClassName,
            CssSelector
         }


    class PropertiesCollection
    {
        //Auto-implemented Property

        public static IWebDriver driver { get; set; }

    }
}
