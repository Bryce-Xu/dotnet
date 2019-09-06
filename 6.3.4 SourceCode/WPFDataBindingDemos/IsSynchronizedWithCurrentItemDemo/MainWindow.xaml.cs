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

namespace IsSynchronizedWithCurrentItemDemo
{
    
    public partial class MainWindow : Window
    {
        List<Client> Clients = null;
        public MainWindow()
        {
            InitializeComponent();
            //设定绑定数据源
            Clients = ClientRepository.GetAllClients();
            DataContext = Clients;
        }
        private void btnFind_Click(object sender, RoutedEventArgs e)
        {
            //查找用户
            var client = Clients.FirstOrDefault(
                c => c.Name.StartsWith(txtFind.Text.Trim()));
            if (client != null)
            {
                //自动选中第一个匹配项
                cboClient.SelectedItem = client;
                //自动滚动显示选中项
                lstClient.ScrollIntoView(client);
            }
        }

        private void cboClient_SelectionChanged(object sender, 
            SelectionChangedEventArgs e)
        {
            lstClient.ScrollIntoView(cboClient.SelectedItem);
        }
    }
}
