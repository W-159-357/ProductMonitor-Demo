   M S B A M L   `   `   `  ����I  EProductMonitor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ProductMonitorProductMonitor  5      C&clr-namespace:ProductMonitor.ViewModelProductMonitor.ViewModel  5          ProductMonitor.MainWindow   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:ProductMonitor     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      <	viewmodel&clr-namespace:ProductMonitor.ViewModel     5        � Title$  生产监控平台��5	      $
��1200��5
      $	��750��5       � WindowStartupLocation$ CenterScreen=�5      '  !System.Windows.Shell.WindowChrome   WindowChrome 5        5   
      GlassFrameThickness$ 0q�6   .��5      � ��5   
   �� 5      .��5      �  � Offset$ 0Q�6    � Color$ 	#ff285173��6*   � 5      $	 0.5Q�6   $ 	#ff244967��6,   � 5      $ 1Q�6   $ 	#ff14273a��6*   5       � RowDefinitions 5   
   �� 5      $��0.67* �6   �� 5      $��9* �6   �� 5       $��0.33* �6   .+�5$   
   �� ���	#5518aabd$��0,0,0,1q�6)   ._�5%      �  � ColumnDefinitions 5&      �� 5'      $��60 �6'   �� 5(      $
��auto �6'   �� 5)      .+�5-      �� $
��10,8q�6   $��Resource/Images/Logo.png��6&   �� 5/      $��1��50      $��Center=�51       �� Orientation$ Vertical=�52      .+�53      �� $��5,0,0,0q�54      $��16(�55      
�������$��生产监控平台��57      �� 58      $	��5,5q�59      $��12(�5:      
�������$$��希望生活能越来越好！��5<      5=      � 5?      $��2��6    5@      �� 5A      �� 5B      $��15 �6(   .+�5E      �� $��Right=�5F      
������ $ 
Horizontal=�5H      	   IsHitTestVisibleInChrome$
	 True��5I      .+�5J      �� -   5        $	����5L         OperatorBtnStyle#��[  5M      �� 5N      -   5        $	����5P      #��[  5Q      �� 5R      -   5        
���  ��$	����5U      #��[  5V      5W      �� 5Y      $��1��5Z      ���	#5518aaba$��0,1,0,0q�5\      ��5]      !� 5^      
 j� TileMode$
 FlipXY=�5_   !    j� Viewport$ 0,0,7,7�5`   !    j� ViewportUnits$ Absolute=�5a   !    !� Visual 5b   "   �� 5c   &   
�������$��1��5e   )   	 �� X1$ 0��5f   )   	 �� X2$ 15��5g   )   	 �� Y1$ 15��5h   )   	 �� Y2$ 0��5i   )   5k      5m      5n      5p      5r      �� 5u   
   $��1��6   ��6&   �� *	MonitorUC+�� 5x   
   $��2��5y      ���	#5518aabd$��0,1,0,0q�5{      ._�5|      �  5}      �� 5~      �� 5      $
��auto �6'   .+�5�      �� ���	#5518aaba$��0,1,0,0q�61   ��5�      !� 5�      $
 FlipXY=�5�      $ 0,0,7,7�5�      $ Absolute=�5�       5�      �� 5�   "   
�������$��1��5�   %   $ 0��5�   %   $ 10��5�   %   $ 10��5�   %   $ 0��5�   %   5�      5�      �� 5�      $��1��5�      $��15(�5�      $
��Bold"�5�      
�������$��Copyright@ wxj��5�      5�      5�      5�      5�      