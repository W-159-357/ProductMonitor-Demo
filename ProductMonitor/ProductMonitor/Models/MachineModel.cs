using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMonitor.Models
{
    /// <summary>
    /// 机台数据模型
    /// </summary>
    public class MachineModel
    {
        /// <summary>
        /// MachineName:        机台名
        /// Status:             机台状态
        /// PlanCount:          计划数量
        /// FinishedCount:      完成数量
        /// OrderNo:            订单号
        /// Percent:            百分比
        /// </summary>
        public string? MachineName { get; set; }
        public string? Status { get; set; }
        public int PlanCount { get; set; }
        public int FinishedCount { get; set; }
        public string? OrderNo { get; set; }
        public double Percent
        {
            get { return FinishedCount * 100.0 / PlanCount; }
            private set { }
        }
    }
}
