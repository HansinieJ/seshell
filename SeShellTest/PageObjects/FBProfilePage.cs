using SeShell.Test.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeShell.Test.PageObjects
{
    class FBProfilePage
    {

        public static string ActualUsernameText()
        {

            {
                return FBProfilePageResources.ActualUsernameTextXPath;
            }
        }

        public static string StatusTextBox()
        {

            {
                return FBProfilePageResources.StatusTextBoxXPath;
            }
        }

        public static string PostButton()
        {

            {
                return FBProfilePageResources.PostButtonXPath;
            }
        }


        public static string PostedStatus()
        {

            {
                return FBProfilePageResources.PostedStatusXPath;
            }
        }

        public static string HomeLink()
        {

            {
                return FBProfilePageResources.HomeLinkXPath;
            }
        }

    }
}
