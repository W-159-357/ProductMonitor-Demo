using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductMonitor.UserControls;
using System.Windows.Controls;
using System.Collections.Specialized;
using System.ComponentModel;
using ProductMonitor.Models;

namespace ProductMonitor.ViewModel
{
    public class MainWindowVM : INotifyPropertyChanged
    {
        /*
            monitorUC:      监控用户控件
            machineCount:   机台总数
            productCount:   生产计数
            badCount:       不良计数
            TimeStr：        时间 小时：分钟
            DateStr：        日期 年-月-日
            WeekStr：        星期
            enviromentList: 环境监控数据
            alarmList:      报警属性
         */
        public event PropertyChangedEventHandler? PropertyChanged;
        // 监控用户控件   (定义为 monitorUC  方便进行里氏替换)
        private UserControl? monitorUC;
        private string machineCount = "02981";
        private string productCount = "16403";
        private string badCount = "01643";
        private List<EnviromentModel> enviromentList;
        private List<AlarmModel> alarmList;
        private List<DeviceModel> deviceList;

        // 视图模型构造函数
        public MainWindowVM()
        {
            #region 初始化环境监控数据
            enviromentList = new List<EnviromentModel>();
            enviromentList.Add(new EnviromentModel { EnItemName = "光照(LUX)", EnItemValue = 173 });
            enviromentList.Add(new EnviromentModel { EnItemName = "噪音(DB)", EnItemValue = 57 });
            enviromentList.Add(new EnviromentModel { EnItemName = "温度(℃)", EnItemValue = 76 });
            enviromentList.Add(new EnviromentModel { EnItemName = "适度(%)", EnItemValue = 64 });
            enviromentList.Add(new EnviromentModel { EnItemName = "PM2.5(m³)", EnItemValue = 17 });
            enviromentList.Add(new EnviromentModel { EnItemName = "硫化氢(PPM)", EnItemValue = 14 });
            enviromentList.Add(new EnviromentModel { EnItemName = "氮气(PPM)", EnItemValue = 19 });
            #endregion

            #region 初始化报警列表
            alarmList = new List<AlarmModel>();
            alarmList.Add(new AlarmModel { Num = "01", Msg = "设备温度过高", AlarmTime = "2024-03-11 15:36:14", Duration = 4 });
            alarmList.Add(new AlarmModel { Num = "02", Msg = "车间温度过高", AlarmTime = "2024-03-28 10:25:18", Duration = 7 });
            alarmList.Add(new AlarmModel { Num = "03", Msg = "设备转速过快", AlarmTime = "2024-04-26 14:19:54", Duration = 12 });
            alarmList.Add(new AlarmModel { Num = "03", Msg = "设备气压偏低", AlarmTime = "2024-05-15 16:43:27", Duration = 10 });
            #endregion

            #region 初始化设备数据
            deviceList = new List<DeviceModel>();
            deviceList.Add(new DeviceModel { DeviceItem = "电能(Kw.h)", Value = 60.5 });
            deviceList.Add(new DeviceModel { DeviceItem = "电压(V)", Value = 395 });
            deviceList.Add(new DeviceModel { DeviceItem = "电流(A)", Value = 5 });
            deviceList.Add(new DeviceModel { DeviceItem = "压差(kpa)", Value = 11 });
            deviceList.Add(new DeviceModel { DeviceItem = "温度(℃)", Value = 36.5 });
            deviceList.Add(new DeviceModel { DeviceItem = "振动(mm/s)", Value = 3.8 });
            deviceList.Add(new DeviceModel { DeviceItem = "转速(r/min)", Value = 2600 });
            deviceList.Add(new DeviceModel { DeviceItem = "气压(kpa)", Value = 0.5 });
            #endregion
        }

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

        #region 日期和时间
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
        #endregion

        #region 机台生产数据
        // 机台总数  
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
        #endregion

        #region 环境监控数据
        public List<EnviromentModel> EnviromentList
        {
            get { return enviromentList; }
            set
            {
                enviromentList = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("EnviromentList"));
                }
            }

        }
        #endregion

        #region 报警属性
        public List<AlarmModel> AlarmList
        {
            get { return alarmList; }
            set
            {
                alarmList = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("AlarmList"));
                }
            }
        }
        #endregion

        #region 设备数据
        public List<DeviceModel> DeviceList
        {
            get { return deviceList; }
            set
            {
                deviceList = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("DeviceList"));
                }
            }
        }
        #endregion

        #region 

        #endregion

    }
}
