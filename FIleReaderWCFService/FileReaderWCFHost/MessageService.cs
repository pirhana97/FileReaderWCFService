using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace FileReaderWCFHost
{
    [ServiceBehavior(UseSynchronizationContext = false)]
    class MessageService : IMessageService
    {
        public void ShowMessage(string message)
        {
            FileReaderWCFHost.MainWindow.MainUI.ShowMessage(message + " | Process: " + Process.GetCurrentProcess().Id.ToString());
        }
    }
}
