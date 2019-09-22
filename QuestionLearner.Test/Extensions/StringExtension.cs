using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionLearner.Test.Extensions
{
    public static class StringExtension
    {
        public static Stream ToStream(this string str, Encoding encoding = null)
        {
            if (encoding == null)
                encoding = Encoding.ASCII;

            byte[] byteArray = encoding.GetBytes(str);
            MemoryStream stream = new MemoryStream();
            stream.Write(byteArray, 0, byteArray.Length);

            return stream;
        }
    }
}
