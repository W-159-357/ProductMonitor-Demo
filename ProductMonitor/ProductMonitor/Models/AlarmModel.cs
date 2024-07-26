using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMonitor.Models
{
    public class AlarmModel
    {
        /*
            num:        编号
            msg:        报警信息
            alarmTime:  报警时间
            duration:   报警时长 单位：秒
         */
        private string num;
        private string msg;
        private string alarmTime;
        private int duration;

        public string Num
        {
            get { return num; }
            set { num = value; }
        }
        public string Msg
        {
            get { return msg; }
            set { msg = value; }
        }
        public string AlarmTime
        {
            get { return alarmTime; }
            set { alarmTime = value; }
        }
        public int Duration
        {
            get { return duration; }
            set { duration = value; }
        }
    }
}
