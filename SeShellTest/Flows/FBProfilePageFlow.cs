using OpenQA.Selenium;
using SeShell.Test.Core;
using SeShell.Test.Enums;
using SeShell.Test.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeShell.Test.Flows
{
    class FBProfilePageFlow : BaseClass
    {
        public FBProfilePageFlow(IWebDriver driver)
        {
            base.SetWebDriverInstance(driver);

            //Driver = driver;
            //new FBLoginPageFlow(Driver);
        }



        public bool VerifyUsername(string expectedUserName)
        {
            Utilities.WaitTillDisplayed(base.Driver, HtmlElementBy.XPath, FBProfilePage.ActualUsernameText());
            string actualUsersName =
                Utilities.FindElement(base.Driver, HtmlElementBy.XPath, FBProfilePage.ActualUsernameText()).Text;

            return actualUsersName == expectedUserName ? true : false;
        }

        public void Post(string status)
        {
            Utilities.WaitTillDisplayed(base.Driver, HtmlElementBy.XPath, FBProfilePage.HomeLink());
            Utilities.FindElement(base.Driver, HtmlElementBy.XPath, FBProfilePage.HomeLink()).Click();

            Utilities.WaitTillDisplayed(base.Driver, HtmlElementBy.XPath, FBProfilePage.StatusTextBox());
            IWebElement PostText = Utilities.FindElement(base.Driver, HtmlElementBy.XPath, FBProfilePage.StatusTextBox());
            PostText.SendKeys(status);

            Utilities.WaitTillDisplayed(base.Driver, HtmlElementBy.XPath, FBProfilePage.PostButton());
            Utilities.FindElement(base.Driver, HtmlElementBy.XPath, FBProfilePage.PostButton()).Click();

        }

        //public void GotoTweetMessages()
        //{
        //    Utilities.WaitTillDisplayed(base.Driver, HtmlElementBy.XPath, TwitterProfilePage.PostButton());
        //    Utilities.FindElement(base.Driver, HtmlElementBy.XPath, TwitterProfilePage.PostButton()).Click();

        //}



        //public AllTweetsPageFlow AllTweets()
        //{
        //    // on navigation to the base page. wait for the landing login button to be loaded
        //    // on load of that button click and get navigated to the actual login page
        //    try
        //    {
        //        this.GotoTweetMessages();

        //        return new AllTweetsPageFlow(base.Driver);
        //    }
        //    catch (System.Exception)
        //    {
        //        throw;
        //    }
        //}

        public bool VerifyPost(string ExpectedPost)
        {
            Utilities.WaitTillDisplayed(base.Driver, HtmlElementBy.XPath, FBProfilePage.PostedStatus());
            string actualTweet = Utilities.FindElement(base.Driver, HtmlElementBy.XPath, FBProfilePage.PostedStatus ()).Text;

            return actualTweet == ExpectedPost ? true : false;


        }
    }
}
