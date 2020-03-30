using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace FileReaderWCFService

{
    public interface IFileReaderServiceCallback //ONLY INCLUDED WITH DUPLEX
    {
        [OperationContract(IsOneWay = true)]
        void OnCallback();
    }
    [ServiceContract(CallbackContract =typeof(IFileReaderServiceCallback))]
    public interface IFileReaderService
    {
        [OperationContract(Name ="ShowMessage")]
        string Echo(string input);

        [OperationContract()]
        string GetFileAttributes(string filePath);

    }

    

}
