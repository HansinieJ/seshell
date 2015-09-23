using SeShell.Test.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeShell.Test.TestData.Data
{
    public class FBPostData : AbstractTestData
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Message { get; set; }
        

        public static List<FBPostData> GetTweetTestCases()
        {
            List<FBPostData> testData = new List<FBPostData>();
            string inputLine;
            using (FileStream inputStream =
                new FileStream(Configuration.TestDataFilePath + @"\FBPostTestData.csv",
                    FileMode.Open,
                    FileAccess.Read))
            {
                StreamReader streamReader = new StreamReader(inputStream);

                while ((inputLine = streamReader.ReadLine()) != null)
                {
                    var data = inputLine.Split(',');
                    testData.Add(new FBPostData
                    {
                        UserName = Convert.ToString((data[0])),
                        Password = Convert.ToString((data[1])),
                        Message = Convert.ToString(data[2])                       
                    });
                }

                streamReader.Close();
                inputStream.Close();
            }

            return testData;
        }
        public override string[] GetClassPropertiesAsArray()
        {
            throw new NotImplementedException();
        }
    }
    }


