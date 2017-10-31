using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumTest
{
    class Program

    {

        //create a reference for the webdriver
        IWebDriver driver = new ChromeDriver();


        static void Main(string[] args)
        {
            
        }

        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver();

            //navigate to Google page 
            PropertiesCollection.driver.Navigate().GoToUrl("http://www.dailymail.co.uk/home/index.html");
            PropertiesCollection.driver.Manage().Window.Maximize();
            PropertiesCollection.driver.Manage().Cookies.DeleteAllCookies();

        }

        [Test]
        public void loginMethod()
        {
            
            LoginPageObject pageLogin = new LoginPageObject();
            pageLogin.login.Click();
            EAPageobject pageEA = pageLogin.Login("vyasm@hotmail.co.uk", "Miteshvyahdtfs210");
            if (pageEA.logout.Displayed)
            {
                Console.WriteLine("Login Directly - PASSED");
                pageEA.logout.Click();
            }
            else
            { 
                Console.WriteLine("Login Directly - FAILED");
                pageLogin.login.Click();
            }
            pageLogin.facebookButton.Click();
            pageLogin.Loginfb("testmolfb6@gmail.com", "testmol");
            Console.WriteLine(pageEA.usernameFb.GetAttribute("value"));
            Console.WriteLine(pageEA.passwordFb.GetAttribute("value"));
            if (pageEA.logout.Displayed)
            {
                Console.WriteLine("Login Facebook - PASSED");
                pageEA.logout.Click();
            }
            else
            {
                Console.WriteLine("Login Facebook - FAILED");
            }
            pageLogin.twitterButton.Click();
            pageLogin.Logintw("testmoltw13", "testmol");
            Console.WriteLine(pageEA.usernameTw.GetAttribute("value"));
            Console.WriteLine(pageEA.passwordTw.GetAttribute("value"));
            if (pageEA.logout.Displayed)
            {
                Console.WriteLine("Login Twitter - PASSED");
                pageEA.logout.Click();
            }
            else
            {
                Console.WriteLine("Login Twitter - FAILED");
            }

        }

        [TearDown]

        public void CleanUp()
        {

            PropertiesCollection.driver.Close();

        }

    }
}


//Initialze the page by calling its reference 
//EAPageobject page = new EAPageobject();

//page.login.Click();
//page.usernameDirect.SendKeys("vyasm@hotmail.co.uk");
//page.passwordDirect.SendKeys("Miteshvyahdtfs210");
//Console.WriteLine(page.usernameDirect.GetAttribute("value"));
//Console.WriteLine(page.passwordDirect.GetAttribute("value"));
//page.loginButtonDirect.Click();
//System.Threading.Thread.Sleep(1000);
//if (page.logout.Displayed)
//{
//    Console.WriteLine("Login Directly - PASSED");
//    page.logout.Click();
//}
//else
//{
//    Console.WriteLine("Login Directly - FAILED");

//}

//page.login.Click();
//page.facebookButton.Click();
//page.usernameFb.SendKeys("testmolfb6@gmail.com");
//page.passwordFb.SendKeys("testmol");
//Console.WriteLine(page.usernameFb.GetAttribute("value"));
//Console.WriteLine(page.passwordFb.GetAttribute("value"));
//page.loginButtonFb.Click();
//System.Threading.Thread.Sleep(1000);
//if (page.logout.Displayed)
//{
//    Console.WriteLine("Login Facebook - PASSED");
//    page.logout.Click();
//}
//else
//{
//    Console.WriteLine("Login Facebook - FAILED");
//}

//page.login.Click();
//page.toOtherAccounts.Click();
//page.twitterButton.Click();
//page.usernameTw.SendKeys("testmoltw13");
//page.passwordTw.SendKeys("testmol");
//Console.WriteLine(page.usernameTw.GetAttribute("value"));
//Console.WriteLine(page.passwordTw.GetAttribute("value"));
//page.loginButtonTw.Click();
//System.Threading.Thread.Sleep(1000);
//if (page.logout.Displayed)
//{
//    Console.WriteLine("Login Twitter - PASSED");
//    page.logout.Click();
//}
//else
//{
//    Console.WriteLine("Login Twitter - FAILED");
//}








////DIRECT
//seleniumMethods.Click("login", PropertyType.Id);
//seleniumMethods.enterText("reg-lbx-email-page", "vyasm@hotmail.co.uk", PropertyType.Id);
//System.Threading.Thread.Sleep(1000);
//seleniumMethods.enterText("reg-lbx-password-page", "Miteshvyas21", PropertyType.Id);
//System.Threading.Thread.Sleep(1000);
//Console.WriteLine("Username = " + SeleniumgetMethods.getText("reg-lbx-email-page", PropertyType.Id));
//Console.WriteLine("Password = " + SeleniumgetMethods.getText("reg-lbx-password-page", PropertyType.Id));
//seleniumMethods.Click("//*[@id='content']/div[2]/div/div/div[1]/div/div[1]/form[1]/fieldset/div[5]/button", PropertyType.XPath);
//System.Threading.Thread.Sleep(1000);
//if (PropertiesCollection.driver.FindElement(By.Id("logout")).Displayed)
//{

//    seleniumMethods.Click("logout", PropertyType.Id);
//    Console.WriteLine("Login Directly - Passed");

//}
//else
//{
//    Console.WriteLine("Login Directly - Failed");

//}


//    //FACEBOOK
//    Assert.IsTrue(driver.FindElement(By.Id("login")).Displayed);
//    seleniumMethods.Click(driver, "login", "Id");
//    Assert.IsTrue(driver.FindElement(By.CssSelector("#content > div.home.reg-lbx > div > div > div:nth-child(3) > div > div.rcolumn-top.p-10 > div.cleared.m-b-15.p-10 > a > span")).Displayed);
//    seleniumMethods.Click(driver, "social-provider", "Name");
//    seleniumMethods.enterText(driver, "email", "testmolfb6@gmail.com", "Id");
//    System.Threading.Thread.Sleep(1000);
//    seleniumMethods.enterText(driver, "pass", "testmol", "Id");
//    Console.WriteLine("Username = " + SeleniumgetMethods.getText(driver, "email", "Id"));
//    Console.WriteLine("Password = " + SeleniumgetMethods.getText(driver, "pass", "Id"));
//    seleniumMethods.Click(driver, "loginbutton", "Id");
//    System.Threading.Thread.Sleep(1000);
//    if (driver.FindElement(By.Id("logout")).Displayed)
//    {
//        seleniumMethods.Click(driver, "logout", "Id");
//        Console.WriteLine("Login Facebook - Passed");
//    }
//    else
//    {
//        Console.WriteLine("Login Facebook - Failed");
//    }


//    //TWITTER
//    Assert.IsTrue(driver.FindElement(By.Id("login")).Displayed);
//    System.Threading.Thread.Sleep(2000);
//    seleniumMethods.Click(driver, "#signin-page > ul > li:nth-child(2) > input", "CssSelector");
//    System.Threading.Thread.Sleep(1000);
//    Assert.IsTrue(driver.FindElement(By.XPath("//*[@id='username_or_email']")).Displayed);
//    seleniumMethods.enterText(driver, "username_or_email", "testmoltw13", "Id");
//    seleniumMethods.enterText(driver, "password", "testmol", "Id");
//    Console.WriteLine("Username = " + SeleniumgetMethods.getText(driver, "username_or_email", "Id"));
//    Console.WriteLine("Password = " + SeleniumgetMethods.getText(driver, "password", "Id"));
//    seleniumMethods.Click(driver, "allow", "Id");
//    System.Threading.Thread.Sleep(1000);
//    if (driver.FindElement(By.Id("logout")).Displayed)
//    {
//        Console.WriteLine("Login Twitter - Passed");
//        seleniumMethods.Click(driver, "logout", "Id");
//    }
//    else
//    {
//        Console.WriteLine("Login Twitter - Failed");
//    }



//for(int i = 0; i < 10; i++) if (i == 7) if(i==8){continue}









//        [Test]
//        public void loginTestDirect()
//        {
//            IWebElement element = driver.FindElement(By.Id("login"));
//            element.Click();
//            element = driver.FindElement(By.Id("reg-lbx-email-page"));
//            element.SendKeys("vyasm@hotmail.co.uk");
//            element = driver.FindElement(By.Id("reg-lbx-password-page"));
//            element.SendKeys("Miteshvyas210");
//            element = driver.FindElement(By.CssSelector("button.reg-btn"));
//            element.Click();
//            System.Threading.Thread.Sleep(6000);
//            Assert.IsTrue(driver.FindElement(By.Id("logout")).Displayed);

//        }

//        [Test]
//        public void loginTestDirect2()
//        {
//            IWebElement element = driver.FindElement(By.Id("login"));
//            element.Click();
//            element = driver.FindElement(By.Id("reg-lbx-email-page"));
//            element.SendKeys("vyasm@hotmail.co.uk");
//            element = driver.FindElement(By.Id("reg-lbx-password-page"));
//            element.SendKeys("Miteshvyas21");
//            element = driver.FindElement(By.CssSelector("button.reg-btn"));
//            element.Click();
//            System.Threading.Thread.Sleep(6000);
//            if (driver.FindElement(By.Id("logout")).Displayed)
//            {
//                Console.WriteLine("pass");

//            }
//            else
//            {
//                Console.WriteLine("fail");

//            }


//        }

//        [Test]
//        public void loginTestSocialfb()
//        {
//            IWebElement element = driver.FindElement(By.Id("login"));
//            element.Click();
//            element = driver.FindElement(By.Name("social-provider"));
//            element.Click();
//            Assert.IsTrue(driver.FindElement(By.XPath("//*[@id='header_block']/span")).Displayed);
//            element = driver.FindElement(By.Id("email"));
//            element.SendKeys("testmolfb6@gmail.com");
//            element = driver.FindElement(By.Id("pass"));
//            element.SendKeys("testmol");
//            element = driver.FindElement(By.Id("loginbutton"));
//            element.Click();
//            Assert.IsTrue(driver.FindElement(By.Id("logout")).Displayed);
//        }

//        [Test]
//        public void loginTestSocialtw()
//        {
//            IWebElement element = driver.FindElement(By.Id("login"));
//            element.Click();
//            element = driver.FindElement(By.CssSelector("#signin-page > ul > li:nth-child(2) > input"));
//            element.Click();
//            Assert.IsTrue(driver.FindElement(By.CssSelector("#header > div > h1 > a")).Displayed);
//            element = driver.FindElement(By.Id("username_or_email"));
//            element.SendKeys("testmoltw13");
//            element = driver.FindElement(By.Id("password"));
//            element.SendKeys("testmol");
//            element = driver.FindElement(By.Id("allow"));
//            element.Click();
//            Assert.IsTrue(driver.FindElement(By.Id("logout")).Displayed);
//        }




