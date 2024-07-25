using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductMonitor.UserControls;
using System.Windows.Controls;
using System.Collections.Specialized;
using System.ComponentModel;

namespace ProductMonitor.ViewModel
{
    public class MainWindowVM : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler? PropertyChanged;
        // 监控用户控件   (定义为 monitorUC  方便进行里氏替换)
        private UserControl? monitorUC;
        public UserControl MonitorUC
        {
            get
            {
                if (monitorUC == null)
                {
                    monitorUC = new MonitorUC();
                }
                return monitorUC;
            }
            set
            {
                monitorUC = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("MonitorUC"));
                }
            }
        }

        // 时间 小时：分钟
        public string TimeStr
        {
            get { return DateTime.Now.ToString("HH:mm"); }
            private set { }
        }

        // 日期 年-月-日
        public string DateStr
        {
            get { return DateTime.Now.ToString("yyyy-MM--dd"); }
            private set { }
        }

        // 星期
        public string WeekStr
        {
            get
            {
                int index = (int)DateTime.Now.DayOfWeek;
                string[] week = new string[7] { "星期天", "星期一", "星期二", "星期三", "星期四", "星期五", "星期六" };
                return week[index];
            }
        }

        // 机台总数
        private string machineCount = "02981";
        public string MachineCount
        {
            get { return machineCount; }
            set
            {
                machineCount = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("MachineCount"));
                }
            }
        }

        // 生产计数
        private string productCount = "16403";
        public string ProductCount
        {
            get { return productCount; }
            set 
            {
                productCount = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("ProductCount"));
                }
            }
        }

        // 不良计数
        private string badCount = "01643";
        public string BadCount
        {
            get { return badCount; }
            set
            {
                badCount = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("BadCount"));
                }
            }
        }

    }
}
