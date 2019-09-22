using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionLearner.Configuration
{
    public static class AppConfigManager
    {
        public static readonly int timeAfterCorrectAnswer;
        public static readonly string recentFilePath;
        public static readonly int countRecentQuestionnaires;

        static AppConfigManager()
        {
            if (!int.TryParse(ConfigurationManager.AppSettings["timeAfterCorrectAnswer"], out timeAfterCorrectAnswer))
                throw new InvalidOperationException("appSettings.timeAfterCorrectAnswer must be of type int");

            recentFilePath = ConfigurationManager.AppSettings["recentFilePath"] ?? "./recent.txt";

            if (!int.TryParse(ConfigurationManager.AppSettings["countRecentQuestionnaires"], out countRecentQuestionnaires))
                throw new InvalidOperationException("appSettings.countRecentQuestionnaires must be of type int");
        }
    }
}
