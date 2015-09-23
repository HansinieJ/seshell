using NUnit.Framework;
using SeShell.Test.Core;
using SeShell.Test.Flows;
using SeShell.Test.TestData.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeShell.Test.TestCases
{
    class FBPostTest : AbstractTest
    {

        [Test, TestCaseSource(typeof(FBPostData), "GetTweetTestCases")]
 
        public void TweetPostSuccessfull(FBPostData  TData)
        {

            

            string currentExecutingMethod = Utilities.GetCurrentMethod();
            var resultsWriter = new ResultsWriter(Constants.ParameterizedTest, currentExecutingMethod, true);
            var TweetTestData = FBPostData.GetTweetTestCases();

            Parallel.ForEach(WebDrivers, (driver, loopState) =>
            {
                var testAsserter = new TestCaseAsserts();
                string currentWebBrowserString = Utilities.GetWebBrowser(driver);

                if (TweetTestData != null)
                {
                    ResultReport testResultReport = new ResultReport();
                    string testFixtureName = Utilities.GenerateTestFixtureName(this.GetType(), currentExecutingMethod,
                    currentWebBrowserString);
                    testResultReport.StartMethodTimerAndInitiateCurrentTestCase(testFixtureName, true);
                    try
                    {

                        FBLoginPageFlow loginPageflow = new FBLoginPageFlow(driver);
                        FBProfilePageFlow profilePageFlow = loginPageflow.LogIn(TData.UserName, TData.Password);

                        //TwitterProfilePageFlow profilePageflow = new TwitterProfilePageFlow(driver);
                        profilePageFlow.Post(TData.Message);



                        


                        testAsserter.AddBooleanAssert(
                         new Action<bool, string>(Assert.IsTrue),
                            profilePageFlow.VerifyPost(TData.Message),
                       
                            Utilities.CombineTestOutcomeString(Constants.SuccessfulLegalEntityCreation, TData.Message));
                   
                        testResultReport.SetCurrentTestCaseOutcome(true, testAsserter.AssertionCount.ToString());
                    }
                    catch (Exception e)
                    {
                        string screenShotIdentifier = String.Format("{0} - {1}", TData.Message, currentExecutingMethod);
                        //string screenShotIdentifier = String.Format("{0} - {1}", posts.PostedTweet, currentExecutingMethod);
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

