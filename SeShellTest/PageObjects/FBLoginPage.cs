using SeShell.Test.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeShell.Test.PageObjects
{
    class FBLoginPage
    {

        public static string UserNameTextBox()
        {

            {
                return FBLoginPageResources.UsernameTextBoxXpath;
            }
        }

        public static string PasswordTextBox()
        {

            {
                return FBLoginPageResources.PasswordTextBoxXpath;
            }
        }

        public static string LoginButton()
        {

            {
                return FBLoginPageResources.LoginButtonXPath;
            }
        }
    }
}
