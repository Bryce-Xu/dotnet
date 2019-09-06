using System;
using System.Collections.Generic;
using System.Linq;
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

namespace WpfAppForCore
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

        private void BtnTest_Click(object sender, RoutedEventArgs e)
        {
            var result = dotNetCoreLibrary.CoreCalculator.Add(100, 200);
            MessageBox.Show($"使用dotNetCore项目中的计算器：100+200={result}");
            result = StandardLibrary.StandardCalculator.Add(100, 200);
            MessageBox.Show($"使用Standard项目中的计算器：100+200={result}");
        }
    }
}
