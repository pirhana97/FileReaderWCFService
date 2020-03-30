using FileReaderWCFService;
using System;

namespace FileReaderServiceClient
{
    public class FileReaderServiceCallback : IFileReaderServiceCallback
    {
        public void OnCallback()
        {
            Console.WriteLine("Callback method is called from client side.");
        }
    }
}