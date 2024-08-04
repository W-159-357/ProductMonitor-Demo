using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ProductMonitor.OpCommand;
using ProductMonitor.UserControls;
using ProductMonitor.ViewModel;
using ProductMonitor.Views;

namespace ProductMonitor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainWindowVM mainWindowVM = new MainWindowVM();

        public MainWindow()
        {
            InitializeComponent();

            // 数据上下文实例化
            this.DataContext = mainWindowVM;
        }

        // 显示车间详情
        private void ShowDetailUC()
        {
            // 跳转到详情页面
            WorkShopDetailUC workShopDetailUC = new WorkShopDetailUC();
            mainWindowVM.MonitorUC = workShopDetailUC;

            // 动画效果（由下而上）
            ThicknessAnimation thicknessAnimation = new ThicknessAnimation(new Thickness(0, 50, 0, -50), new Thickness(0, 0, 0, 0), new TimeSpan(0, 0, 0, 0, 500));

            // 透明度
            DoubleAnimation doubleAnimation = new DoubleAnimation(0, 1, new TimeSpan(0, 0, 0, 0, 4000));

            Storyboard.SetTarget(thicknessAnimation, workShopDetailUC);
            Storyboard.SetTarget(doubleAnimation, workShopDetailUC);
            Storyboard.SetTargetProperty(thicknessAnimation, new PropertyPath("Margin"));
            Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath("Opacity"));

            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(thicknessAnimation);
            storyboard.Children.Add(doubleAnimation);
            storyboard.Begin();
        }

        // 展示详情命令
        public Command ShowDetailICmm
        {
            get { return new Command(ShowDetailUC); }
        }

        // 返回按钮(返回首页)
        private void GoBack()
        {
            MonitorUC monitor = new MonitorUC();
            mainWindowVM.MonitorUC = monitor;
        }

        // 返回首页命令
        public Command GoBackCmm
        {
            get { return new Command(GoBack); }
        }

        // 最小化
        private void BtnMinimize(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        // 最大化
        private void BtnMaximize(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;
            }
            else
            {
                this.WindowState = WindowState.Normal;
            }
        }

        // 关闭
        private void btnClone(object sender, RoutedEventArgs e)
        {
            this.Close();       // 关闭窗口
            Environment.Exit(0);    // 关闭应用
        }

        #region 弹出配置窗口
        // 显示配置窗口
        private void ShowSettingWin()
        {
            // 父子关系
            SettingsWin settingsWin = new SettingsWin() { Owner = this };
            settingsWin.ShowDialog();
        }
        // 创建 弹出配置窗口命令
        public Command ShowSettingCmm
        {
            get { return new Command(ShowSettingWin); }
        }
        #endregion
    }
}