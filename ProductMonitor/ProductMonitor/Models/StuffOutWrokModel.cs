using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMonitor.Models
{
    /// <summary>
    /// 缺岗数据模型
    /// </summary>
    public class StuffOutWrokModel
    {
        /// <summary>
        /// OutWorkCount:   缺岗次数
        /// StuffName:      员工姓名
        /// Position:       职位
        /// ShowWidth:      显示宽度
        /// </summary>
        public int OutWorkCount { get; set; }
        public string StuffName { get; set; }
        public string Position { get; set; }
        public int ShowWidth 
        {
            get
            {
                return OutWorkCount * 50 / 100;
            } 
        }
    }
}
