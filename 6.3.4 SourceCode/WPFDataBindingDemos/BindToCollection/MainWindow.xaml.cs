using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace BindToCollection
{
    
    public partial class MainWindow : Window
    {
        //绑定数据源
        ObservableCollection<DataItem> items;
        //用于生成唯一的数据标识
        int itemIdentifier = -1;
        public MainWindow()
        {
            InitializeComponent();
            //提取数据
            items = MyDataProvider.GetAllItems();
            //初始化数据标识
            itemIdentifier = items.Count;
            //实现绑定
            lstDataItems.ItemsSource = items;

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //生成唯一数据标识
            itemIdentifier++;
            //向对象集合中添加一个数据对象
            DataItem obj = new DataItem();
            obj.ItemID = itemIdentifier;
            obj.ItemValue = $"新记录{itemIdentifier}";
            items.Add(obj);
            //ListBox滚动显示新加入的记录
            lstDataItems.ScrollIntoView(obj);
            lstDataItems.SelectedIndex = items.Count - 1;
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (lstDataItems.SelectedIndex != -1)
                items.RemoveAt(lstDataItems.SelectedIndex);
        }

        private void btnModify_Click(object sender, RoutedEventArgs e)
        {
            //确保有选中的当前记录
            if (lstDataItems.SelectedIndex != -1)
            {
                //取出对应的数据对象
                var dataItem = lstDataItems.SelectedItem as DataItem;
                //属性值的修改，会导致ListBox相关记录的自动刷新
                dataItem.ItemValue = $"修改于：{DateTime.Now.ToLocalTime()}";
            }
        }
    }
}
