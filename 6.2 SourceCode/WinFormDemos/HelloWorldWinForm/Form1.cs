using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //实例化各个控件
            InitializeComponent();
        }

        //按钮单击事件响应代码
        private void BtnClick_Click(object sender, EventArgs e)
        {
            // MessageBox.Show($"当前时间：{DateTime.Now}");

            //通过控件Id访问特定的控件
            lblTime.Text=$"当前时间：{DateTime.Now}";
        }
    }
}
