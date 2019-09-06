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

namespace WhatIsDataBind2
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


        private void btnSetBig_Click(object sender, RoutedEventArgs e)
        {
            //设置TextBlock文本块控件的字体大小为30
            txtFont.FontSize = 30;
            //滑块控件会自动滑动到30这个位置，不需要单独控制
        }

        private void btnSetMiddle_Click(object sender, RoutedEventArgs e)
        {
            txtFont.FontSize = 20;
        }

        private void btnSetSmall_Click(object sender, RoutedEventArgs e)
        {
            txtFont.FontSize = 10;
        }
    }
}
