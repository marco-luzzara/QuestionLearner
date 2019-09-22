using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionLearner.Test.Extensions
{
    public static class StreamExtension
    {
        public static async Task<string> CastToString(this Stream stream)
        {
            stream.Seek(0, SeekOrigin.Begin);
            using (var sr = new StreamReader(stream))
            {
                return await sr.ReadToEndAsync().ConfigureAwait(false);
            }
        }
    }
}
