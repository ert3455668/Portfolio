using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CreateExcel
{
    public class FileCRUD
    {
        //我更新囉
        public static void CreateFile(string folderName, string fileName, string fileExtension)
        {
            //path路徑
            //folderName文件夾名稱
            //fileName文件名稱從txet Bading資料來源
            //fileExtension 副檔名
            //創建檔案的條件 1.路徑兩個一個文件夾一個 2.檔名 3.寫入的副檔名
            string path = $@"C:\\Bulidschool\{folderName}\{fileName}.{fileExtension}";
            //判別檔案是否存在

            if (fileName == null)
            {
                MessageBox.Show("檔名不可為空白");
            }
            else
            {
                if (System.IO.File.Exists(path))
                {
                    //存在時會跳出請更換檔名
                    MessageBox.Show(fileName + "檔案已存在請更換檔名");
                }
                else
                {
                    //不存在時直接創建檔名
                    using (StreamWriter writer = new StreamWriter(path))
                    {
                        MessageBox.Show(fileName + "創建成功");

                    }
                }
            }

        }
        public static object WriteFile(string writeContent)
        {
            string FileName;
            var openFileDialog = new Microsoft.Win32.OpenFileDialog();
            openFileDialog.ShowDialog();
            using (StreamWriter writer = new StreamWriter(openFileDialog.FileName))
            {
                writer.WriteLine(writeContent);
            }

            return MessageBox.Show("寫入成功");
        }

        public static object ReadFile()
        {
            var openFileDialog = new Microsoft.Win32.OpenFileDialog();
            openFileDialog.ShowDialog();
            string fileContent = System.IO.File.ReadAllText(openFileDialog.FileName);
            if (fileContent == "")//這裡不可用null
            {

                return MessageBox.Show("沒有任何內容有夠可悲");
            }
            else
            {
                return MessageBox.Show(fileContent);
            }

        }
    }
}
