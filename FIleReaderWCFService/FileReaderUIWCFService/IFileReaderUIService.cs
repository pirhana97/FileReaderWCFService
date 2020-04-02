using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace FileReaderUIWCFService
{
    [ServiceContract()]
    public interface IFileReaderUIService
    {
        [OperationContract()]
        string GetAttributes(string filePath);
    }
}
