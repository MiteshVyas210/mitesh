using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumTest
{
    class EAPageobject
    {
        public EAPageobject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.Id, Using = "login")]
        public IWebElement login { get; set; }

        [FindsBy(How = How.Id, Using = "reg-lbx-email-page")]
        public IWebElement usernameDirect { get; set; }

        [FindsBy(How = How.Id, Using = "reg-lbx-password-page")]
        public IWebElement passwordDirect { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='content']/div[2]/div/div/div[1]/div/div[1]/form[1]/fieldset/div[5]/button")]
        public IWebElement loginButtonDirect { get; set; }

        [FindsBy(How = How.Id, Using = "logout")]
        public IWebElement logout { get; set; }

        [FindsBy(How = How.Name, Using = "social-provider")]
        public IWebElement facebookButton { get; set; }

        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement usernameFb { get; set; }

        [FindsBy(How = How.Id, Using = "pass")]
        public IWebElement passwordFb { get; set; }

        [FindsBy(How = How.Id, Using = "loginbutton")]
        public IWebElement loginButtonFb { get; set; }

        [FindsBy(How = How.Id, Using = "wa_not_you_lb")]
        public IWebElement toOtherAccounts { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".twitter-button")]
        public IWebElement twitterButton { get; set; }

        [FindsBy(How = How.Id, Using = "username_or_email")]
        public IWebElement usernameTw { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement passwordTw { get; set; }

        [FindsBy(How = How.Id, Using = "allow")]
        public IWebElement loginButtonTw { get; set; }
    }
}
