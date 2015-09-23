using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SeShell.Test.Core;
using SeShell.Test.Enums;
using SeShell.Test.Flows;
using SeShell.Test.PageObjects;
using SeShell.Test.TestData.Data;

namespace SeShell.Test.TestCases
{
    public class FBLoginTest : AbstractTest
    {
        /// <summary>
        /// Test for successful login
        /// </summary>
        [Test, TestCaseSource(typeof(FBLoginData), "GetLoginTestCases")]
        public void LoginSuccessfull(FBLoginData LoginData)
        {
            string currentExecutingMethod = Utilities.GetCurrentMethod();
            var resultsWriter = new ResultsWriter(Constants.ParameterizedTest, currentExecutingMethod, true);
            var loginTestData = FBLoginData.GetLoginTestCases();

            Parallel.ForEach(WebDrivers, (driver, loopState) =>
            {
                var testAsserter = new TestCaseAsserts();
                string currentWebBrowserString = Utilities.GetWebBrowser(driver);

                if (loginTestData != null)
                {
                    ResultReport testResultReport = new ResultReport();
                    string testFixtureName = Utilities.GenerateTestFixtureName(this.GetType(), currentExecutingMethod,
                    currentWebBrowserString);
                    testResultReport.StartMethodTimerAndInitiateCurrentTestCase(testFixtureName, true);
                    try
                    {
                        FBLoginPageFlow loginPageflow = new FBLoginPageFlow(driver);
                        FBProfilePageFlow profilePageFlow = loginPageflow.LogIn(LoginData.UserName, LoginData.Password);

                        testAsserter.AddBooleanAssert(
                         new Action<bool, string>(Assert.IsTrue),
                         profilePageFlow.VerifyUsername(LoginData.ExpectedUsername),
                         Utilities.CombineTestOutcomeString(Constants.SuccessfulUserLogin, LoginData.UserName));
                        testResultReport.SetCurrentTestCaseOutcome(true, testAsserter.AssertionCount.ToString());
                    }
                    catch (Exception e)
                    {
                        string screenShotIdentifier = String.Format("{0} - {1}", LoginData.ExpectedUsername, currentExecutingMethod);
                        base.HandleException(e, screenShotIdentifier, driver, testResultReport, testAsserter, resultsWriter);
                        Assert.Fail("***** TwitterLoginSuccessful Failed *****");
                    }
                    finally
                    {
                        testResultReport.StopMethodTimerAndFinishCurrentTestCase();
                        base.TestCases.Add(testResultReport.currentTestCase);
                    }
                }
            });

            resultsWriter.WriteResultsToFile(this.GetType().Name, TestCases);


        }
    }
}
