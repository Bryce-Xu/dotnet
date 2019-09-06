using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace BindToCollection
{
    class MyDataProvider
    {
        /// <summary>
        /// 用于生成用于展示WPF数据绑定特性的测试用数据对象集合
        /// </summary>
        /// <returns></returns>
        public static ObservableCollection<DataItem> GetAllItems()
        {
            //使用ObservableCollection来保存数据源
            var items = new ObservableCollection<DataItem>();
            //创建10条测试用数据
            for (int i = 0; i < 10; i++)
            {
                items.Add(new DataItem()
                {
                    ItemID = i,
                    ItemValue = $"Item{i}"
                });
            }
            return items;
        }
    }
}
