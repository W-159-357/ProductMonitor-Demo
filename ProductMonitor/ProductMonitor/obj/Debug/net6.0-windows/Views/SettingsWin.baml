   M S B A M L   `   `   `  ����I  EProductMonitor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:ProductMonitor.ViewsProductMonitor.Views  5      &     ProductMonitor.Views.SettingsWin   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:ProductMonitor.Views     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � Title$  系统配置信息��5      $	��800��5	      $	��450��5
      
������ $��Microsoft YaHei)�5      $��
ExtraLight"�5       � 
ResizeMode$ NoResize=�5       � WindowStartupLocation$ CenterOwner=�5      '  !System.Windows.Shell.WindowChrome   WindowChrome 5        5   
      GlassFrameThickness$ -1q�6    � 	Resources 5       �� 
TargetType �� Property �� Value	 �� 
TargetType
 �� Triggers P� Property P� Value��%�  '	�       �� 5   
   " 	�6   .�5      ��  � ��
 ���� 6+   �� 5       � �� 5      �� 5      "	 	�6&   .R�5      �� $��30��6!   #��z��6-   ._�5      �� $
��10,0q�5   !   $
��Left=�5   !   $��Center=�5    !   5!      5"      5$      
 5%      P� 5&       �@d�	IsChecked$
 TrueY�6/   . �5'      ��  � �� �#18aabd63   5(      5*      5+      .��5-      �  � RowDefinitions 5.   
   �� 5/      $��30 �6   �� 50       � ColumnDefinitions 53   
   �� 54      $	��130 �6   �� 55      .+�59   
   �� $
��10,0q�6   $��Center=�6"   �� 5:      $!��../Resource/Fonts/#iconfont)�5;      $��14(�5<      $	���5=       �� 5>      $�系统配置信息��6   5?      �� 5B   
   $��1��5C      ���#ddd$��0,0,1,0q�5E      �� 5F   
   $��1��6   $
��0,10q�6"   .+�5G      	� -   5        $��设备清单��5I       d� 	IsChecked$
 TrueY�5J      
 � Tag$ data1��5K      	� 5L      -   5        $��环境检测��5N      $ data2��5O      	� 5P      -   5        $��设备检测��5R      $ data3��5S      	� 5T      -   5        $��	配置一��5V      $ data4��5W      	� 5X      -   5        $��	配置二��5Z      $ data5��5[      5\      �� 5^   
   $��1��5_      $��1��5`      $��Hidden=�5a      .��5b       � -   5          �Name$ frame��5c        � NavigationUIVisibility$ Hidden=�5d        � Source$ SettingsPage.xaml?�5e      5f      5g      5h      