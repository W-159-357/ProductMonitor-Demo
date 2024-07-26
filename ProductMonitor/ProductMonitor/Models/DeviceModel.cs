using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMonitor.Models
{
    // 设备数据模型
    public class DeviceModel
    {
        /*
            deviceItem:     设备监控项名称
            value:          值
         */
        private string deviceItem;
        private double value;

        public string DeviceItem
        {
            get { return deviceItem; }
            set { deviceItem = value; }
        }
        public double Value
        {
            get { return value; }
            set { this.value = value; }
        }
    }
}
