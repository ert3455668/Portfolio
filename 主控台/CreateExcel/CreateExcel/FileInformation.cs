using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateExcel
{
    public class FileInformation:INotifyPropertyChanged
    {
        public string FileName { get; set; }

        public string FolderPath { get; set; }
        public string Extension { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;

        public string GetFilePath()
        {
            return $"{FolderPath}\\{FileName}.{Extension}";
        }
    }
}
