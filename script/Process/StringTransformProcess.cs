using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRCPhotoArrange.Process
{
    class StringTransformProcess
    {
        public string TransformInputFolderLabel(string folderName)
        {
            return "入力フォルダ名 : " + folderName;
        }

        public string TransformOutputFolderLabel(string folderName)
        {
            return "出力フォルダ名 : " + folderName;
        }
    }
}
