using QuestionLearner.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace QuestionLearner.Extensions
{
    public static class QuestionExtension
    {
        public static Question FromXml(XElement xml, IDictionary<string, string> resourceDict)
        {
            string text = xml.Element("text").Value;
            string answer = xml.Element("answer").Value;
            string resourceId = xml.Element("resource").Value;

            ImageFile imgFile = null;
            string resourcePath = null;
            if (resourceDict.TryGetValue(resourceId, out resourcePath))
                imgFile = new ImageFile(resourcePath);

            return new Question(text, answer, imgFile);
        } 
    }
}
