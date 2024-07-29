using ProductMonitor.Models;
using System;
using System.Collections.Generic;
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
    /// RaderUC.xaml 的交互逻辑
    /// </summary>
    public partial class RaderUC : UserControl
    {
        public RaderUC()
        {
            InitializeComponent();

            SizeChanged += OnSizeChanged;
        }

        public static readonly DependencyProperty ItemSourceProperty =
            DependencyProperty.Register("ItemSource", typeof(List<RaderModel>), typeof(RaderUC));

        // 支持数据绑定 （依赖属性）        -> 雷达图的数据源
        public List<RaderModel> ItemSource
        {
            get { return (List<RaderModel>)GetValue(ItemSourceProperty); }
            set { SetValue(ItemSourceProperty, value); }
        }

        // 窗口大小发生变化时，进行雷达图的重新绘制
        private void OnSizeChanged(object sender, SizeChangedEventArgs e)
        {
            Darw();
        }

        // 图像绘制的方法
        public void Darw()
        {
            // 判断是否有数据源
            if (ItemSource == null || ItemSource.Count == 0)
            {
                return;
            }

            // 清空之前绘制的图像
            mainCanvas.Children.Clear();
            p1.Points.Clear();
            p2.Points.Clear();
            p3.Points.Clear();
            p4.Points.Clear();
            p5.Points.Clear();

            // 调整大小(正方形)
            double size = Math.Min(RenderSize.Width, RenderSize.Height);
            LayGrid.Height = size;
            LayGrid.Width = size;
            // 半径
            double raduis = size / 2;
            // 每一步的跨度
            double step = 360.0 / ItemSource.Count;
            for (int i = 0; i < ItemSource.Count; i++)
            {
                double x = (raduis - 20) * Math.Cos((step * i - 90) * Math.PI / 180);  // x偏移量
                double y = (raduis - 20) * Math.Sin((step * i - 90) * Math.PI / 180);  // y偏移量

                // 找到每个点的 X Y 坐标
                p1.Points.Add(new Point(raduis + x, raduis + y));
                p2.Points.Add(new Point(raduis + x * 0.75, raduis + y * 0.75));
                p3.Points.Add(new Point(raduis + x * 0.50, raduis + y * 0.50));
                p4.Points.Add(new Point(raduis + x * 0.25, raduis + y * 0.25));

                // 数据多边形
                p5.Points.Add(new Point(raduis + x * ItemSource[i].ItemValue * 0.01, raduis + y * ItemSource[i].ItemValue * 0.01));

                // 文字处理
                TextBlock txt = new TextBlock();
                txt.Width = 60;
                txt.FontSize = 10;
                txt.TextAlignment = TextAlignment.Center;
                txt.Text = ItemSource[i].ItemName;
                txt.Foreground = new SolidColorBrush(Color.FromArgb(100, 255, 255, 255));
                // 计算左边、上边间距
                txt.SetValue(Canvas.LeftProperty, raduis + (raduis - 10) * Math.Cos((step * i - 90) * Math.PI / 180) - 30);
                txt.SetValue(Canvas.TopProperty, raduis + (raduis - 10) * Math.Sin((step * i - 90) * Math.PI / 180) - 5);

                mainCanvas.Children.Add(txt);
            }
        }
    }
}
