using QuestionLearner.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionLearner.Forms
{
    public static class Utils
    {
        internal static async Task AddToRecentQuestionnairesIfOut(Stream recentStorage, string questionnairePath)
        {
            var sr = new StreamReader(recentStorage);
            var sw = new StreamWriter(recentStorage);
            
            var lines = new List<string>();

            recentStorage.Seek(0, SeekOrigin.Begin);
            string fContent = await sr.ReadToEndAsync().ConfigureAwait(false);

            fContent.Split(Environment.NewLine.ToArray(), StringSplitOptions.RemoveEmptyEntries).ToList()
                .ForEach(line => lines.Add(line));

            if (!lines.Any(s => s == questionnairePath))
            {
                lines.Insert(0, questionnairePath);

                fContent = string.Join(Environment.NewLine, lines.Take(AppConfigManager.countRecentQuestionnaires));
                recentStorage.Seek(0, SeekOrigin.Begin);
                await sw.WriteAsync(fContent).ConfigureAwait(false);
            }

            await sw.FlushAsync();
        }
    }
}
