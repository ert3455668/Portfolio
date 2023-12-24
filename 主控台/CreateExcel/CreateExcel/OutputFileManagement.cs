using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Shapes;
using File = System.IO.File;

namespace CreateExcel
{
    public class OutputFileManagement
    {
        public FileInformation FileInformation { get; set; }
        public string FilePath { get; set; }
        public OutputFileManagement(FileInformation fileInfo)
        {
            FileInformation = fileInfo;
            FilePath = FileInformation.GetFilePath();
        }
        public event EventHandler<string> ReadTextFromFile;
        public void CreateFile()
        {
            if (HasData(FileInformation))
            {
                if (!File.Exists(FilePath))
                {
                    File.Create(FilePath);
                    MessageBox.Show("檔案創建成功");

                }
            }
            else
            {
                MessageBox.Show("檔名、副檔名、路徑不可為空白");
            }

        }


        private bool HasData(FileInformation fileInfo)
        {
            
            return !string.IsNullOrWhiteSpace(fileInfo.FolderPath) && !string.IsNullOrWhiteSpace(fileInfo.FileName) && !string.IsNullOrWhiteSpace(fileInfo.Extension);
        }
        public void WriteFile(string writeContent)
        {
            using (StreamWriter writer = new StreamWriter(FilePath))
            {
                writer.WriteLine(writeContent);
                writer.Flush();
            }

            MessageBox.Show("寫入成功");
        }

        public void ReadFile()
        {
            using (StreamReader reader = new StreamReader(FilePath))
            {
                while (reader.Peek() != -1)
                {
                    var line = reader.ReadLine();
                    ReadTextFromFile?.Invoke(this, line);
                }
            }
        }
    }
}
