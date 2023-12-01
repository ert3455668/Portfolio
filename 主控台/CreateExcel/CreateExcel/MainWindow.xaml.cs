using Microsoft.Win32;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.RightsManagement;
using System.Text;
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



namespace CreateExcel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public OutputFileManagement OutputFileManagement { get; set; }  
        public FileInformation FileInformation { get; set; }
        public event PropertyChangedEventHandler? PropertyChanged;

        public MainWindow()
        {
            InitializeComponent();
            FileInformation = new FileInformation();
        }
        private void SetupOutputFileManagement()
        {
            OutputFileManagement = new OutputFileManagement(FileInformation);
            OutputFileManagement.ReadTextFromFile -= OutputFileManagement_ReadTextFromFile;
            OutputFileManagement.ReadTextFromFile += OutputFileManagement_ReadTextFromFile;
        }
        private void OutputFileManagement_ReadTextFromFile(object? sender, string e)
        {
            textLog.AppendText(e);
            textLog.ScrollToEnd();
        }

        private void Button_Create(object sender, RoutedEventArgs e)
        {
            SetupOutputFileManagement();
            OutputFileManagement.CreateFile();
        }

        private void Button_Write(object sender, RoutedEventArgs e)
        {
            SetupOutputFileManagement();
            string writeContent = "Hello Excel";
            OutputFileManagement.WriteFile(writeContent);
        }

        private void Button_Read(object sender, RoutedEventArgs e)
        {
            SetupOutputFileManagement();
            OutputFileManagement.ReadFile();
        }

        private void SelectFolder_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new CommonOpenFileDialog() { IsFolderPicker = true };
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                FileInformation.FolderPath = dialog.FileName;
            }
        }
    }
}
