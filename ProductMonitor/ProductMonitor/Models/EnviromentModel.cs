using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMonitor.Models
{
    public class EnviromentModel
    {
        /*
            enItemName:     环境项名称
            enItemValue:    环境项的值
         */
        private string enItemName;
        private int enItemValue;

        public string EnItemName
        {
            get { return enItemName; }
            set { enItemName = value; }
        }

        public int EnItemValue
        {
            get { return enItemValue; }
            set { enItemValue = value; }
        }
    }
}
