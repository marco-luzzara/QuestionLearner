using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuestionLearner.Forms;
using QuestionLearner.Test.Extensions;
using System;
using System.IO;
using System.Text;

namespace QuestionLearner.Test.Form
{
    [TestClass]
    public class UtilsTest
    {
        [TestClass]
        public class AddToRecentQuestionnairesIfOutTest
        {
            [TestMethod]
            public void AddToRecentQuestionnairesIfOut_EmptyStream()
            {
                using (var stream = "".ToStream())
                {
                    Utils.AddToRecentQuestionnairesIfOut(stream, "questionnaire1").Wait();
                    var str = stream.CastToString().GetAwaiter().GetResult();

                    Assert.AreEqual("questionnaire1", str);
                }
            }

            [TestMethod]
            public void AddToRecentQuestionnairesIfOut_WithinLimit()
            {
                var recent_content = $"test2{Environment.NewLine}test1";

                using (var stream = recent_content.ToStream())
                {
                    Utils.AddToRecentQuestionnairesIfOut(stream, "test3").Wait();
                    var str = stream.CastToString().GetAwaiter().GetResult();

                    Assert.AreEqual($"test3{Environment.NewLine}{recent_content}", str);
                }
            }

            [TestMethod]
            public void AddToRecentQuestionnairesIfOut_LimitExceeded()
            {
                var recent_content = $"test3{Environment.NewLine}test2{Environment.NewLine}test1";

                using (var stream = recent_content.ToStream())
                {
                    Utils.AddToRecentQuestionnairesIfOut(stream, "test4").Wait();
                    var str = stream.CastToString().GetAwaiter().GetResult();

                    Assert.AreEqual($"test4{Environment.NewLine}test3{Environment.NewLine}test2", str);
                }
            }
        }
    }
}
