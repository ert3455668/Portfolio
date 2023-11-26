using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
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
    public partial class MainWindow : Window,INotifyPropertyChanged
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        private void INotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }



        public string CreateFileNameText
        {
            get
            {
                return CreateFileName;
            }
            set
            {
                CreateFileName = value;
                INotifyPropertyChanged(); 


            }
        }
        public string CreateFileNameTxt
        {
            get
            {
                return CreateFileNametxt;
            }
            set
            {
                CreateFileNametxt = value;
                INotifyPropertyChanged();


            }
        }

        private string CreateFileName;
       
        private string CreateFileNametxt;

        string txtContent;



        private void Button_Create(object sender, RoutedEventArgs e)
        {
            //判別檔案是否存在
            //if(File.Exists(path)) 
            // {
            //     File.Delete(path);
            // }
            //寫進去的 東西
            string ExcelWrite = "Car.xlsx";
            //設置路徑 
            string filePatth = $@"D:\\Bulidschool\\excel\\{CreateFileName}.csv";
            string WriteFileName = CreateFileName;

            using (StreamWriter writer = new StreamWriter(filePatth))
            {
                writer.WriteLine(ExcelWrite);
            }
            MessageBox.Show("創建成功");

        }

        private void Button_Write(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new Microsoft.Win32.OpenFileDialog();
            openFileDialog.ShowDialog();
            using (StreamWriter writer = new StreamWriter(openFileDialog.FileName))
            {
                writer.WriteLine(txtContent);
            }
            MessageBox.Show("寫入完成");
        }




        //以下對txt操作
        private void CreateTxt(object sender, RoutedEventArgs e)
        {
            //新增TXT檔案的路徑
            string path = $@"D:\\Bulidschool\\txt\\{CreateFileNametxt}";
            //判別檔案是否存在
            if (System.IO.File.Exists(path))
            {
                //存在時會跳出請更換檔名
                MessageBox.Show(CreateFileNametxt + "檔案已存在請更換檔名");
            }
            else
            {
                //不存在時直接創建檔名
                using (StreamWriter writer = new StreamWriter(path))
                {
                    MessageBox.Show(CreateFileNametxt+"創建成功");

                }
            }


           

        }

        private void WriteTxt(object sender, RoutedEventArgs e)
        {
            //挑選寫入的檔案
            var openFileDialog = new Microsoft.Win32.OpenFileDialog();
            string TxtWrite = "Hello WPF";
            openFileDialog.DefaultExt = ".txt";//預設副檔案名
            openFileDialog.ShowDialog();
            using (StreamWriter writer = new StreamWriter(openFileDialog.FileName))
            {
                writer.WriteLine(TxtWrite);
            }

        }

        private void ReadTxt(object sender, RoutedEventArgs e)
        {
            //挑選要讀取的txt
            var openFileDialog = new Microsoft.Win32.OpenFileDialog();
            openFileDialog.ShowDialog();
            txtContent = System.IO.File.ReadAllText(openFileDialog.FileName);
            MessageBox.Show(txtContent);
        }
    }
}
