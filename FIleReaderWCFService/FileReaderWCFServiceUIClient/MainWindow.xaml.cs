using FileReaderServiceClient;
using FileReaderWCFService;
using System;
using System.IO;
using System.ServiceModel;
using System.Windows;
using OpenFileDialog = System.Windows.Forms.OpenFileDialog;

namespace FileReaderWCFServiceUIClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnBrowseClick(object sender, EventArgs e)
        {
            WriteFilePath filePath = new WriteFilePath();
            string filename = filePath.writeFilePath();
            FilePath.Text = filename;

        }

        private void OnGetContentsClick(object sender, EventArgs e)
        {

            //ChannelFactory<IFileReaderService> factory = new ChannelFactory<IFileReaderService>("");
            //IFileReaderService proxy = factory.CreateChannel();

            //FileAttributes.Text=proxy.GetFileAttributes(FilePath.Text);
            //IFileReaderServiceCallback callback = new FileReaderServiceCallback();
            //InstanceContext context = new InstanceContext(callback);
            //FileReaderServiceProxy.FileReaderServiceProxy proxy = new FileReaderServiceProxy.FileReaderServiceProxy(context);

            FileReaderUIServiceProxy.FileReaderServiceProxy proxy = new FileReaderUIServiceProxy.FileReaderServiceProxy();
            string filePath = FilePath.Text;

            FileAttributes.Text = proxy.GetAttributes(filePath);
         //   string message = proxy.Echo(filePath);
         //   MessageBox.Show(message);

            //string fileAttributes = proxy.GetFileAttributes(filePath);
            //MessageBox.Show(fileAttributes);


        }
    }
}





// FileInfo fi = new FileInfo(FilePath.Text);
// bool fileExists = fi.Exists;

//  if (fileExists)
//  {
//FileReaderServiceProxy.FileReaderServiceProxy proxy = new FileReaderServiceProxy.FileReaderServiceProxy();
//string filePath = FilePath.Text;
//FileAttributes.Content = proxy.GetFileAttributes(filePath);

//proxy.Close();
//  }
//  else
//  {
//      MessageBox.Show("File does not exists");
//  }