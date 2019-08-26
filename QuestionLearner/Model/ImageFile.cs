using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionLearner.Model
{
    public class ImageFile
    {
        public Image Image{ get; }
        public string FilePath { get; }
        public string FileName
        {
            get
            {
                return Path.GetFileName(this.FilePath);
            }
        }

        public ImageFile(string filepath)
        {
            this.FilePath = filepath;
            Image = Image.FromFile(filepath);
        }
    }
}
