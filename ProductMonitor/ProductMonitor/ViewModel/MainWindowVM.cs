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
            monitorUC:          监控用户控件
            machineCount:       机台总数
            productCount:       生产计数
            badCount:           不良计数
            TimeStr：           时间 小时：分钟
            DateStr：           日期 年-月-日
            WeekStr：           星期
            enviromentList:     环境监控数据
            alarmList:          报警属性
            raderList:          雷达属性
            stuffOutWorkList:   缺岗员工数据
            workShopList:       车间属性
            machineList:        机台属性
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
        private List<RaderModel> raderList;
        private List<StuffOutWrokModel> stuffOutWorkList;
        private List<WorkShopModel> workShopList;
        private List<MachineModel> machineList;

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

            #region 初始化雷达数据
            raderList = new List<RaderModel>();
            raderList.Add(new RaderModel { ItemName = "客梯", ItemValue = 31.00 });
            raderList.Add(new RaderModel { ItemName = "排烟风机", ItemValue = 90.50 });
            raderList.Add(new RaderModel { ItemName = "稳压设备1", ItemValue = 27.45 });
            raderList.Add(new RaderModel { ItemName = "稳压设备2", ItemValue = 67.00 });
            raderList.Add(new RaderModel { ItemName = "喷淋水泵", ItemValue = 72.43 });
            raderList.Add(new RaderModel { ItemName = "供水机", ItemValue = 35.66 });
            #endregion

            #region 缺岗员工数据
            stuffOutWorkList = new List<StuffOutWrokModel>();
            stuffOutWorkList.Add(new StuffOutWrokModel { StuffName = "王晓婷", Position = "工程师", OutWorkCount = 43 });
            stuffOutWorkList.Add(new StuffOutWrokModel { StuffName = "张飞", Position = "技术员", OutWorkCount = 19 });
            stuffOutWorkList.Add(new StuffOutWrokModel { StuffName = "李一如", Position = "技术售后", OutWorkCount = 108 });
            stuffOutWorkList.Add(new StuffOutWrokModel { StuffName = "张晓峰", Position = "工程师", OutWorkCount = 79 });
            stuffOutWorkList.Add(new StuffOutWrokModel { StuffName = "王世辉", Position = "技术实施", OutWorkCount = 61 });
            #endregion

            #region 车间属性数据
            workShopList = new List<WorkShopModel>();
            WorkShopList.Add(new WorkShopModel { WorkShopName = "焊接车间", WorkingCount = 56, WaitCount = 27, WrongCount = 7, StopCount = 3 });
            WorkShopList.Add(new WorkShopModel { WorkShopName = "封装车间", WorkingCount = 48, WaitCount = 19, WrongCount = 10, StopCount = 6 });
            WorkShopList.Add(new WorkShopModel { WorkShopName = "贴片车间", WorkingCount = 67, WaitCount = 31, WrongCount = 5, StopCount = 4 });
            WorkShopList.Add(new WorkShopModel { WorkShopName = "生产车间", WorkingCount = 82, WaitCount = 13, WrongCount = 6, StopCount = 2 });
            #endregion

            #region 机台属性数据
            machineList = new List<MachineModel>();
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                int plan = random.Next(100, 1000);
                int finish = random.Next(100, plan);
                machineList.Add(new MachineModel
                {
                    MachineName = "焊接机" + (i + 1),
                    FinishedCount = finish,
                    PlanCount = plan,
                    Status = "作业中",
                    OrderNo = "H202407151" + finish.ToString()
                });
            }
        }
        #endregion

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

        #region 雷达数据属性
        public List<RaderModel> RaderList
        {
            get { return raderList; }
            set
            {
                raderList = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("RaderList"));
                }
            }
        }
        #endregion

        #region 缺岗员工数据
        public List<StuffOutWrokModel> StuffOutWorkList
        {
            get { return stuffOutWorkList; }
            set
            {
                stuffOutWorkList = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("StuffOutWorkList"));
                }
            }
        }
        #endregion

        #region 车间属性
        public List<WorkShopModel> WorkShopList
        {
            get { return workShopList; }
            set
            {
                workShopList = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("WorkShopList"));
                }
            }
        }
        #endregion

        #region 机台属性集合
        public List<MachineModel> MachineList
        {
            get { return machineList; }
            set
            {
                machineList = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("MachineList"));
                }
            }
        }
        #endregion
    }
}
