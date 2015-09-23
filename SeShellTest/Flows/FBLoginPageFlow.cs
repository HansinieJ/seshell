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
    class FBLoginPageFlow : BaseClass
    {
        public FBLoginPageFlow(IWebDriver driver)
        {
            base.SetWebDriverInstance(driver);
            NavigateTo(string.Empty);
        }


        public FBProfilePageFlow LogIn(string userName, string password)
        {
            // on navigation to the base page. wait for the landing login button to be loaded
            // on load of that button click and get navigated to the actual login page
            try
            {
                this.LoginAs(userName, password);

                return new FBProfilePageFlow(base.Driver);
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public void LoginAs(string username, string password)
        {
            Utilities.WaitTillDisplayed(this.Driver, HtmlElementBy.XPath, FBLoginPage.UserNameTextBox());
            Utilities.WaitTillDisplayed(this.Driver, HtmlElementBy.XPath, FBLoginPage.PasswordTextBox());

            IWebElement userNameElement = Utilities.FindElement(this.Driver, HtmlElementBy.XPath, FBLoginPage.UserNameTextBox());
            IWebElement passwordElement = Utilities.FindElement(this.Driver, HtmlElementBy.XPath, FBLoginPage.PasswordTextBox());

            //Utilities.ClearElements(new IWebElement[] { userNameElement, passwordElement });

            userNameElement.SendKeys(username);
            passwordElement.SendKeys(password);

            Utilities.WaitTillDisplayed(this.Driver, HtmlElementBy.XPath, FBLoginPage.LoginButton());
            Utilities.FindElement(this.Driver, HtmlElementBy.XPath, FBLoginPage.LoginButton()).Click();
        }

    }
}
