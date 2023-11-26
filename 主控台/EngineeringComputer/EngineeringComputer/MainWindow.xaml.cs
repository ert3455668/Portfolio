using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace EngineeringComputer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window,INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        //來源通道 
        public Size Size { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Size = new Size();
            
        }
        private void INotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        
        //輸出通道
        private string Num;
        public string CalculationReslt
        {
            get {
                return Num;
            }
            set {
                Num = value;
                INotifyPropertyChanged();
            }
        }
        public string CalculationResltMM
        {
            get
            {
                return Num;
            }
            set
            {
                Num = value;
                INotifyPropertyChanged();
            }
        }
        public void Calculate(double num1,double num2)
        {
            //計算公式
            double num3 = Math.Round(num1 * num2 * 10.89 / 1000000,3);
            double num4 = Math.Round(num1 * num2 * 10.89 / 100000, 3);
            //取小數點後三位 

            CalculationReslt = num3.ToString()+" CM ";
            CalculationResltMM = num4.ToString() + " MM ";


        }
        private void CalculateButton(object sender, RoutedEventArgs e)
        {
            Calculate(Size.size1,Size.size2);

            //Long = CalculationReslt;
            //CalculationReslt = "幹你娘";
        }

      
    }
}
