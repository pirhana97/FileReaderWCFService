using FileReaderUIWCFService;
using FileReaderWCFService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace FileReaderUIServiceProxy
{
    public class FileReaderServiceProxy : ClientBase<IFileReaderUIService>, IFileReaderUIService
    {
        public string GetAttributes(string filePath)
        {
            return base.Channel.GetAttributes(filePath);
        }
    }
}
