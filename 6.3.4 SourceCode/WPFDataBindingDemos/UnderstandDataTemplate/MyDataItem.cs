using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace UnderstandDataTemplate
{
    /// <summary>
    /// 数据对象
    /// </summary>
    class MyDataItem
    {
        public string Value
        {
            get;
            set;
        }

        public override string ToString()
        {
            return "MyDateItem: " + Value;
        }
    }

    /// <summary>
    /// 用于提供绑定数据源
    /// </summary>
    class DataProvider
    {
        public static ObservableCollection<MyDataItem> MyDataObjectCollection = new ObservableCollection<MyDataItem>();

         static DataProvider()
        {
            for (int i = 0; i < 10; i++)
            {
                MyDataItem item = new MyDataItem();
                item.Value = "Item" + i.ToString();
                MyDataObjectCollection.Add(item);
            }
        }
    }
}
