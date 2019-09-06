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

namespace ShowPolymorphismCollection
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

            DataItems = new ObservableCollection<MyBase>();
            FillData();
        }
        //使用依赖属性，构建动态更新UI界面的数据源对象集合
        public ObservableCollection<MyBase> DataItems
        {
            get { return (ObservableCollection<MyBase>)GetValue(DataItemsProperty); }
            set { SetValue(DataItemsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DataItems.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DataItemsProperty =
            DependencyProperty.Register("DataItems", typeof(ObservableCollection<MyBase>), typeof(MainWindow),
            new PropertyMetadata(null));


        //填充对象集合
        void FillData()
        {
            for (int i = 1; i <= 10; i++)
            {
                DataItems.Add(new MyStringClass()
                {
                    Information = "Image" + i
                });
                DataItems.Add(new MyImageClass()
                {
                    ImageUri = string.Format("Images/{0}.jpg", i)
                });
            }
        }
    }
}
