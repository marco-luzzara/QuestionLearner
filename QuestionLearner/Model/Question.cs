using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace QuestionLearner.Model
{
    public class Question
    {
        public string Text { get; set; }
        public string Answer { get; set; }
        public ImageFile Resource { get; set; }

        public Question(string text, string answer)
        {
            this.Text = text;
            this.Answer = answer;
        }

        public Question(string text, string answer, ImageFile resource) : this(text, answer)
        {
            this.Resource = resource;
        }
    }
}
