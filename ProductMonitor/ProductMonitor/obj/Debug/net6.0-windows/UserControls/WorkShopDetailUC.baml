   M S B A M L   `   `   `  ����I  EProductMonitor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:ProductMonitor.UserControlsProductMonitor.UserControls  5      U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 5      2    ,ProductMonitor.UserControls.WorkShopDetailUC   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:ProductMonitor.UserControls     5      Dlvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � 	Resources  5       �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers P� Property P� Value��%R  '	�       �� 5   
   " 	�6   .�5      ��  � ��$ 22��6'   �� 5       � ��$ 50��6&   �� 5       � �� �#ddd6+   �� 5       � �� �#BC8F8F6+   �� 5       � ��$ 11(�6)   �� 5       � �� �#87CEEB6,   �� 5       � �� 5      �� 5      " 	�6&   .R�5      �� #��z��6!   ._�5      �� $��Center=�6/   $��Center=�6L   5      5      5       5      P� 5        �@d�	IsChecked$
 TrueY�6/   . �5!      ��  � ��
 � ���63   �� 5"       � ��
 �����63   5#      5%      5&      .��5(      �  � RowDefinitions 5)   
   �� 5*      $��1* �6   �� 5+      $��9* �6   .+�5/   
   �� $
��10,5q�6   ���	#5518aabd6   �� 50   
   $��1��51      $
��10,5q�52      ���	#5518aabd53      �� 56   
   $��80��57      $��28��58      $��30,15q�59      $
��Left=�5:      $��Center=�5;      $��返回��5=         BtnStyle#��[  5>      
	 � Tag$		 ��5?      ��5<      �� *	GoBackCmm+
 �� RelativeSource
 ��  �� AncestorType
 Window5?      �� 5A   
   $
��30,0q�5B      $��Right=�5C      $��Center=�5D       �� Orientation$ 
Horizontal=�5E      .+�5F      �� $
��10,0q�5G      $��Center=�5H      
�������$��机台状态��5J      	� 5M      $��全部��6    d� 	IsChecked$
 TrueY�6'   	� 5N      $��作业��6   	� 5O      $��等待��6   	� 5P      $��故障��6   	� 5Q      $��停机��6   5R      �� 5U   
   $��1��5V      $
��10,5q�5W      $��Hidden=�5X      .��5Y      �� $	��0,5q�6   ��6(   �� *MachineList+��5Z      �� 5[      .R�5\      A�  A� Columns$ 5��6&   5]      ��5a      �� 5b      .R�5c      �� $	��260��5d      $
��10,5q�5e      ���	#0a18aabd���#87CEFA$��0,1,0,0q�5h      ._�5i      � $��11(�6#    5j   "   �� 5k   &   $
��1.2* �64   �� 5l   &   $��6* �64   �� 5m   &   $��0.95* �64   �� 5n   &   $��0.95* �64   �� 5o   &   $��0.95* �64   .+�5s   "   �� $
��20,0q�5t   %   $��Center=�5u   %   $��12(�5v   %   ���	#aaffffff�� 5x   &   $!��../Resource/Fonts/#iconfont)�6*   $	���6S    �� 5y   &   �6*   �� *MachineName+5z   #   �� 5{   "   $��Right=�5|   %   $��Center=�5}   %   $ 
Horizontal=�5~   %   .+�5   &   �� $��7��5�   )   $��7��5�   )   ���#7FFF00 �� CornerRadius$ 4��5�   )   �� 5�   &   $
��10,0q�5�   )   ���#7FFF00��5�   )   �� *Status+5�   #   (   "ProductMonitor.UserControls.RingUC  5�   "   $��1��5�   %   $��30q�5�   %      PercentValue 5�   %   �� *	Percent+�� 5�   "   $��2��5�   %   $
��15,0q�5�   %   $��Center=�5�   %   $ 
Horizontal=�5�   %   .+�5�   &   �� $��Center=�5�   )   ���	#55ffffff$��任务状态：��5�   )   �� 5�   &   $	��5,1q�5�   )   $��Center=�5�   )   ���#7FFF00$��1q�5�   )   $��10(�5�   )   ���#7FFF00��5�   )   �� *Status+5�   )   5�   #   �� 5�   "   $��2��5�   %   $��Right=�5�   %   $��Center=�5�   %   �� 5�   &   -   5        ���	#55ffffff �� TextDecorations$
 None{�5�   )   .�6@   
[详情]5�   '   5�   #   �� 5�   "   $��3��5�   %   $
��15,0q�5�   %   $��Center=�5�   %   $ 
Horizontal=�5�   %   .+�5�   &   �� ���	#55ffffff$��任务进度：��6G   �� 5�   &   
��������� 5�   *   �6.   �� *FinishedCount+ �� 5�   *   $�/��6.    �� 5�   *   �6.   �� *	PlanCount+5�   '   5�   #   �� 5�   "   $��4��5�   %   $
��15,0q�5�   %   $��Center=�5�   %   $ 
Horizontal=�5�   %   .+�5�   &   �� ���	#55ffffff$��	工单：��6G   �� 5�   &   
���������6C   �� *	OrderNo+5�   #   5�      5�      5�      5�      5�      �� 5�   
   -   5         ��Name$ detail��5�      $��2��5�      ���	#22000000$y�	Collapsed=�5�      ._�5�      �� -   5        $ detailContent��5�      $��Bottom=�5�      ���	#f5f7f9fa���#98FB98$��0,1,0,0q�5�      ._�5�      � $	��350��6    5�      �� 5�      $��1* �6(   �� 5�      $
��0.8* �6(   �� 5�      $
��8.2* �6(   .+�5�      �� $
��20,0q�5�      $
��Left=�5�      $��Center=�5�      $��16(�5�      ���#555$��机台效率趋势图��5�      �� 5�      -   5        $��40��5�      $��40��5�      $��Right=�5�      $��Center=�5�      $	����5�      $��20(�5�      ���#333  OperatorBtnStyle#��[ 5�      �� 5�      $��1��5�      $
��50,0q�5�      $
��Left=�5�      $��Center=�5�      $ 
Horizontal=�5�      .+�5�      �� $��7��5�      $��7��5�      $
��25,0q�5�      ���#7FFF005�      �� 5�      $��作业��6$   �� 5      $��7��5     $��7��5     $
��25,0q�5     ���#EEEE005     �� 5     $��等待��6$   �� 5     $��7��5     $��7��5	     $
��25,0q�5
     ���#FF63475     �� 5     $��故障��6$   �� 5     $��7��5     $��7��5     $
��25,0q�5     ���#8B86825     �� 5     $��停机��6$   5     �� 5     $��1��5     $
��50,0q�5     $��Right=�5     $��Center=�5     $ 
Horizontal=�5     .+�5     	� $��当日��6&   $
 TrueY�63   	� 5     $��当周��6&   	� 5     $��当月��6&   	� 5      $��当年��6&   5!     #  LiveCharts.Wpf.CartesianChart  5$     $��2��6)   $
��20,0q�66   &   LiveCharts.Wpf.Charts.Base.Chart   AxisX 5&       LiveCharts.Wpf.Axis     Labels9  3LiveCharts.Wpf.Converters.StringCollectionConverter$} w21-12,20-12,21-01,21-02,21-03,21-03,21-05,21-06,21-07,21-08,21-09,21-10,21-11,22-01,22-02,22-03,22-04,22-05,22-06,22-07 6'      	Separator 5'  "     LiveCharts.Wpf.Separator  5(  &      Step$ 1Q�64      StrokeThickness$ 0Q�6=   5*        AxisY 5.          MaxValue$	 100Q�6'      MinValue$ 0Q�66    5/  "     50  &   $ 10Q�64      Stroke �	#080000006>   52        Series 57     (  "LiveCharts.Wpf.StackedColumnSeries    LiveCharts.Wpf.Series   Title$ 作业��58  !      Fill �#7FFF00   MaxColumnWidth$ 15Q�5:  !       StrokeThickness$  0Q�5;  !   !   Values;	  5LiveCharts.Wpf.Converters.NumericChartValuesConverter$�! �74.11, 65.42, 56.78, 70.12, 73.45, 67.89, 45.67, 65.23, 52.45, 54.67,67.54, 62.65, 63.21, 68.90, 76.34, 69.87, 68.48, 64.75, 59.99, 51.02	 5<  !     5>     $ 等待��5?  !    �#EEEE00$ 15Q�5A  !   $  0Q�5B  !   $|! v5.23, 5.45, 2.67, 3.89, 4.56, 5.78, 6.90, 7.12, 8.34, 9.56, 3.67, 3.89, 2.01, 3.23, 4.45, 5.67, 6.88, 7.99, 8.11, 9.22	 5C  !     5E     $ 故障��5F  !    �#FF6347$ 15Q�5H  !   $  0Q�5I  !   $�! �2.45, 5.32, 9.87, 14.65, 13.21, 7.68, 11.49, 17.56, 19.32, 0.78, 4.59, 12.34, 6.21, 15.67, 8.43, 10.55, 6.90, 13.76, 18.89, 8.54	 5J  !     5L     $ 停机��5M  !    �#8B8682$ 15Q�5O  !   $  0Q�5P  !   $�! �24.32, 25.67, 29.01, 37.45, 18.23, 22.54, 43.89, 12.65, 34.78, 48.90, 26.34, 28.21, 30.56, 42.79, 13.47, 25.98, 17.65, 38.22, 49.50, 42.01	 5Q  !   5S     5T     5U     5V     5W     5X     