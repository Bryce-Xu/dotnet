using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace BindToCollection
{
    //被绑定的数据对象，应该实现INotifyPropertyChanged接口，
    //这样一来，属性值变化时WPF的UI界面也能自动刷新
    class DataItem : INotifyPropertyChanged
    {
        //此属性变更事件是实现界面自动刷新的关键
        public event PropertyChangedEventHandler PropertyChanged;

        private string _itemvalue = "";
        public string ItemValue
        {
            get
            {
                return _itemvalue;
            }
            set
            {
                _itemvalue = value;
                //触发属性值变更事件（真实程序中应该要检查新值和老值是否一致，不一致时才触发事件)
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ItemValue"));
            }
        }

        private int _itemID = -1;
        public int ItemID
        {
            get
            {
                return _itemID;
            }
            set
            {
                _itemID = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("ItemID"));

            }
        }
    }
}
