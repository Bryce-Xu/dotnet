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

namespace UnderstandDataTemplate
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
        private void btnNotUseDataTemplate_Click(object sender, RoutedEventArgs e)
        {
            NoDataTemplate win = new NoDataTemplate();
            win.ShowDialog();
        }

        private void btnUseDataTemplate_Click(object sender, RoutedEventArgs e)
        {
            UseInlineDataTemplate win = new UseInlineDataTemplate();
            win.ShowDialog();
        }

        private void btnNotUseDataTemplate2_Click(object sender, RoutedEventArgs e)
        {
            UseDisplayMemberPath win = new UseDisplayMemberPath();
            win.ShowDialog();
        }

        private void btnUseDataTemplateInResource_Click(object sender, RoutedEventArgs e)
        {
            UseDataTemplateInResource win = new UseDataTemplateInResource();
            win.ShowDialog();
        }

        private void btnAutoApplyDataTemplate_Click(object sender, RoutedEventArgs e)
        {
            AutoApplyDataTemplate win = new AutoApplyDataTemplate();
            win.ShowDialog();
        }

    }
}
