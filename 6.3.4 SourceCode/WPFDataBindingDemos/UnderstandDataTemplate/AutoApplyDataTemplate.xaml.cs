using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace UnderstandDataTemplate
{
    /// <summary>
    /// AutoApplyDataTemplate.xaml 的交互逻辑
    /// </summary>
    public partial class AutoApplyDataTemplate : Window
    {
        public AutoApplyDataTemplate()
        {
            InitializeComponent();
        }

        private void cboItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //如果当前项不可见，自动滚动显示它
            lstItems.ScrollIntoView(cboItems.SelectedItem);
        }
    }
}
