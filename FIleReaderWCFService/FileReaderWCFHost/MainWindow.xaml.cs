using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FileReaderWCFHost
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow MainUI { get; set; }
        SynchronizationContext _SyncContext = null;
        public MainWindow()
        {
            InitializeComponent();

            btnStart.IsEnabled = true;
            btnStop.IsEnabled = false;

            MainUI = this;

            this.Title = "UI Running on Thread" + Thread.CurrentThread.ManagedThreadId;
            _SyncContext = SynchronizationContext.Current;
        }

        ServiceHost _HostFileReadService = null;
        ServiceHost _MessageService = null;

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            _HostFileReadService = new ServiceHost(typeof(FileReaderWCFService.FileReaderService));
            _MessageService = new ServiceHost(typeof(MessageService));
            ////Add a service endpoint
            //_HostFileReadService.AddServiceEndpoint(typeof(FileReaderWCFService.IFileReaderService), new WSHttpBinding(), "http://localhost:8080/FileReaderWCFService/FileReaderService");

            ////Enable metadata exchange
            //ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
            //smb.HttpGetEnabled = true;
            //_HostFileReadService.Description.Behaviors.Add(smb);


            _HostFileReadService.Open();
            _MessageService.Open();

            btnStart.IsEnabled = false;
            btnStop.IsEnabled = true;
        }

        private void BtnStop_Click(object sender, RoutedEventArgs e)
        {
            _HostFileReadService.Close();
            _MessageService.Close();

            btnStart.IsEnabled = true;
            btnStop.IsEnabled = false;

        }
    }
}