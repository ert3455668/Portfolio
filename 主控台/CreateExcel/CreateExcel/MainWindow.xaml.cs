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
        public string FolderPath { get; set; }
        public string Extension {  get; set; }  
        public MainWindow()
        {
            InitializeComponent();
        }
        public event PropertyChangedEventHandler? PropertyChanged;

        public string FileName { get; set; }


        private void Button_Create(object sender, RoutedEventArgs e)
        {
            string fileName = FileName;
            FileCRUD.CreateFile(FolderPath, fileName, ".csv");
        }



        private void Button_Write(object sender, RoutedEventArgs e)
        {
            /*
                var openFileDialog = new Microsoft.Win32.OpenFileDialog();
                openFileDialog.ShowDialog();
                using (StreamWriter writer = new StreamWriter(openFileDialog.FileName))
                {
                    writer.WriteLine(txtContent);
                }
                MessageBox.Show("寫入完成");
            */
            string writeContent = "Hello Excel";
            FileCRUD.WriteFile(writeContent);
        }
        private void Button_Read(object sender, RoutedEventArgs e)
        {
            FileCRUD.ReadFile();
        }



        //以下對txt操作
        private void CreateTxt(object sender, RoutedEventArgs e)
        {
            //創txt
            if (!string.IsNullOrWhiteSpace(FolderPath))
            {
                FileCRUD.CreateFile(FolderPath, FileName, "txt");
            }
        }

        private void WriteTxt(object sender, RoutedEventArgs e)
        {
            /*
           openFileDialog = new Microsoft.Win32.OpenFileDialog();
           string TxtWrite = "Hello WPF";
           openFileDialog.DefaultExt = ".txt";//預設副檔案名
           openFileDialog.ShowDialog();
           using (StreamWriter writer = new StreamWriter(openFileDialog.FileName))
           {
                writer.WriteLine(TxtWrite);
           }
            */
            //挑選寫入的檔案
            string writeContent = "Hello WPF";
            FileCRUD.WriteFile(writeContent);
        }





        private void ReadTxt(object sender, RoutedEventArgs e)
        {
            //挑選要讀取的txt
            /*
            var openFileDialog = new Microsoft.Win32.OpenFileDialog();
            openFileDialog.ShowDialog();
            txtContent = System.IO.File.ReadAllText(openFileDialog.FileName);
            MessageBox.Show(txtContent);
            */
            FileCRUD.ReadFile();
        }

        private void SelectFolder_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new CommonOpenFileDialog() { IsFolderPicker = true };
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                FolderPath = dialog.FileName;
            }
        }


        //public void CreateFile(string folderName,string fileName,string fileExtension)
        //{
        //    //path路徑
        //    //folderName文件夾名稱
        //    //fileName文件名稱從txet Bading資料來源
        //    //fileExtension 副檔名
        //    //創建檔案的條件 1.路徑兩個一個文件夾一個 2.檔名 3.寫入的副檔名
        //    string  path = $@"C:\\Bulidschool\{folderName}\{fileName}.{fileExtension}";
        //    //判別檔案是否存在

        //    if(fileName == null)
        //    {
        //        MessageBox.Show("檔名不可為空白");
        //    }
        //    else
        //    {
        //        if (System.IO.File.Exists(path))
        //        {
        //            //存在時會跳出請更換檔名
        //            MessageBox.Show(fileName + "檔案已存在請更換檔名");
        //        }
        //        else
        //        {
        //            //不存在時直接創建檔名
        //            using (StreamWriter writer = new StreamWriter(path))
        //            {
        //                MessageBox.Show(fileName + "創建成功");

        //            }
        //        }
        //    }

        //}
        //public static object WriteFile(string writeContent)
        //{
        //    string FileName;
        //    var openFileDialog= new Microsoft.Win32.OpenFileDialog();
        //    openFileDialog.ShowDialog();
        //    using (StreamWriter writer = new StreamWriter(openFileDialog.FileName))
        //    {
        //        writer.WriteLine(writeContent);
        //    }

        //    return MessageBox.Show("寫入成功");
        //}

        //public static object ReadFile() 
        //{   
        //    var openFileDialog = new Microsoft.Win32.OpenFileDialog();
        //    openFileDialog.ShowDialog();
        //    string fileContent = System.IO.File.ReadAllText(openFileDialog.FileName);
        //    if (fileContent == "")//這裡不可用null
        //    {

        //        return MessageBox.Show("沒有任何內容有夠可悲");
        //    }
        //    else
        //    {
        //        return MessageBox.Show(fileContent);
        //    }

        //}


    }
}
