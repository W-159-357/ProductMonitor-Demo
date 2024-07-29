using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMonitor.Models
{
    /// <summary>
    /// 车间数据模型
    /// </summary>
    public class WorkShopModel
    {
        /// <summary>
        /// WorkShopName:       车间名称
        /// WorkingCount:       作业数量
        /// WaitCount:          等待数量
        /// WrongCount:         故障数量
        /// StopCount:          停机数量
        /// TotalCount:         总数量
        /// </summary>
        public string WorkShopName { get; set; }
        public int WorkingCount { get; set; }
        public int WaitCount { get; set; }
        public int WrongCount { get; set; }
        public int StopCount { get; set; }
        public int TotalCount
        {
            get
            {
                return WorkingCount + WaitCount + WrongCount + StopCount;
            }
        }
    }
}
