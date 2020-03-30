using FileReaderWCFService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace FileReaderServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
           
            IFileReaderServiceCallback callback = new FileReaderServiceCallback();
            InstanceContext context = new InstanceContext(callback);

            FileReaderServiceProxy.FileReaderServiceProxy proxy = new FileReaderServiceProxy.FileReaderServiceProxy(context);

            Console.WriteLine("Client is running at " + DateTime.Now.ToString());
            Console.WriteLine("Enter the filepath: ");
            string filePath = Console.ReadLine();
            Console.WriteLine(proxy.Echo(filePath));
            Console.WriteLine(proxy.GetFileAttributes(filePath));
            Console.ReadLine();
        }
    }
}




//Used in simplex connection :
// FileReaderServiceProxy.FileReaderServiceProxy proxy = new FileReaderServiceProxy.FileReaderServiceProxy();