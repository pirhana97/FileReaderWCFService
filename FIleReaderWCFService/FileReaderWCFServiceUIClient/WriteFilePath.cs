using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileReaderWCFServiceUIClient
{
    class WriteFilePath
    {
        public string writeFilePath()
        {
            string filename = null;
            OpenFileDialog browseFile = new OpenFileDialog();

            if (browseFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filename = browseFile.FileName;

            }
            return filename;
        }
    }
}
