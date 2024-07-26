using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMonitor.Models
{
    public class RaderModel
    {
        /*
            itemName:       项名称
            itemValue:      项值
         */
        private string itemName;
        private double itemValue;

        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }
        public double ItemValue
        {
            get { return itemValue; }
            set { itemValue = value; }
        }
    }
}