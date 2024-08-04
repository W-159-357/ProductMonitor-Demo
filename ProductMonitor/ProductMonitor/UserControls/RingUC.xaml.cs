using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProductMonitor.UserControls
{
    /// <summary>
    /// RingUC.xaml 的交互逻辑
    /// </summary>
    public partial class RingUC : UserControl
    {
        public RingUC()
        {
            InitializeComponent();

            SizeChanged += OnSizeChanged;       // 界面大小发生改变，重新绘制
        }

        // 
        private void OnSizeChanged(object sender, SizeChangedEventArgs e)
        {
            Drag();
        }

        // 百分比
        public double PercentValue
        {
            get { return (double)GetValue(PercentValueProperty); }
            set { SetValue(PercentValueProperty, value); }
        }

        // 属性依赖注入
        public static readonly DependencyProperty PercentValueProperty =
            DependencyProperty.Register("PercentValue", typeof(double), typeof(RingUC));

        // 圆环绘制
        private void Drag()
        {
            LayOutGrid.Width = Math.Min(RenderSize.Width, RenderSize.Height);   // 设置Grid大小
            double radius = LayOutGrid.Width / 2;

            double x = radius + (radius - 3) * Math.Cos((PercentValue % 100 * 3.6 - 90) * Math.PI / 180);
            double y = radius + (radius - 3) * Math.Sin((PercentValue % 100 * 3.6 - 90) * Math.PI / 180);

            int isHalf = PercentValue < 50 ? 0 : 1;
            // M:移动     A:画弧
            string pathStr = $"M{radius + 0.01} 3A{radius - 3} {radius - 3} 0 {isHalf} 1 {x} {y}";      // 移动路径
            // Geometry : 几何类
            var converter = TypeDescriptor.GetConverter(typeof(Geometry));
            path.Data = converter.ConvertFrom(pathStr) as Geometry;
        }
    }
}
