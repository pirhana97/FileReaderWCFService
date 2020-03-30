using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using FileReaderWCFService;

namespace FileReaderWCFServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a URI to serve as the base address
             Uri httpUrl = new Uri("http://localhost:8090/FileReaderWCFService/FileReaderService");
         

            //Create ServiceHost
            ServiceHost host = new ServiceHost(typeof(FileReaderWCFService.FileReaderService), httpUrl);

            //Add a service endpoint
         //   host.AddServiceEndpoint(typeof(FileReaderWCFService.IFileReaderService), new WSHttpBinding(), "");


            //Start the Service
            host.Open();
            Console.WriteLine("Service is host at " + DateTime.Now.ToString());
            Console.WriteLine("Host is running... Press  key to stop");
            Console.ReadLine();
            host.Close();
        }
    }
}







//Create a URI to serve as the base address
//Uri httpUrl = new Uri("http://localhost:8090/FileReaderWCFService/FileReaderService");
//   Uri httpUrl = new Uri("http://localhost:4437/FileReaderWCFService/FileReaderService");

//Create ServiceHost
//ServiceHost host = new ServiceHost(typeof(FileReaderWCFService.FileReaderService), httpUrl);

//Add a service endpoint
//   host.AddServiceEndpoint(typeof(FileReaderWCFService.IFileReaderService), new WSHttpBinding(), "");

//Enable metadata exchange
//    ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
//    smb.HttpGetEnabled = true;
//    host.Description.Behaviors.Add(smb);

//Start the Service
//host.Open();
//Console.WriteLine("Service is host at " + DateTime.Now.ToString());
//Console.WriteLine("Host is running... Press  key to stop");
//Console.ReadLine();
//host.Close();