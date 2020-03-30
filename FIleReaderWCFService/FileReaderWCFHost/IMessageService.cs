using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace FileReaderWCFHost
{
    [ServiceContract()]
    public interface IMessageService
    {
        [OperationContract()]
        void ShowMessage(string message);
    }
}
