   M S B A M L   `   `   `  ����C  ?DoAnTGVL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:DoAnTGVLDoAnTGVL  5   	   7 clr-namespace:DoAnTGVL.UControlsDoAnTGVL.UControls  5   	   7 clr-namespace:DoAnTGVL.UControlsDoAnTGVL.UControls  5   	       DoAnTGVL.ThoMain   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:DoAnTGVL     5   	   4UCSuaCV clr-namespace:DoAnTGVL.UControls     5   	   7
UCCViecTho clr-namespace:DoAnTGVL.UControls     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � WindowStartupLocation$  CenterScreen=�5
   	    � WindowStyle$
 None=�5   	    � Title$ ThoMain��5   	   $	��800��6   $
��1500��6&    � 	Resources 5         OpenMenu �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  	CloseMenu��%S  &	        &	 �     �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ gridMainmenu��6a   .\�5        $ 0:0:0.3��6'   $	 200Q�69   5      5      �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ gridMainmenu��6a   .\�5        $ 0:0:0.3��6'   $ 50Q�69   5      5      5(       � Triggers 5)      :� 5*   
   	 :� RoutedEvent$	 ButtonBase.Click��6   
 :� 
SourceName$
 ButtonOpenMenu��66   .[�5+      �� #��[  6   5,      :� 50   
   $	 ButtonBase.Click��6   $
 ButtonCloseMenu��66   .[�51      �� #��[ 6   52      :� 56   
   $	 UIElement.MouseLeave��6   $
 gridMainmenu��6:   .[�57      �� #��[ 6   58      .��5:      � -   5         �Name$ gridMain��5:       � ColumnDefinitions 5;   
   .+�5=   
   � -   5        $ gridMainWin��5=      $��Right=�6$   $
��1450��6@   5@      � 5A   
   -   5        $ gridMainmenu��5A      $��50��6%   $
��Left=�60   .+�5B      �� ���#CCCCCC$��1q�6+   ���#FFFFFF �� CornerRadius$ 5��6T   $
��Left=�6e    J� Effect 5C      3  -System.Windows.Media.Effects.DropShadowEffect  5D         ShadowDepth$ 0Q�6'      
BlurRadius$ 10Q�67      Opacity$	 0.7Q�6G      Color$ Black��6U   ._�5F      � z�5G      V� 5H      .~�5I      �� �� 5J      �� 5K      T� 5L      5M      .+�5O      �� $��0��6"    �� Orientation$ Vertical=�62   $��Stretch=�6I   ���#FFFFFF.+�5Q      �� .+�5R      �� -   5         ��Name$ ButtonOpenMenu��5R   %   $��50��6=   $��50��6I   $��0q�6T   $
��Left=�6_   $	��Top=�6z    0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 6�   ���	#FF31577E��6�   Z� ��6�   Z� .��5S   "   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Menu=�6:   $��30��6F   $��30��6Q   5T      �� 5U      -   5        $ ButtonCloseMenu��5U   %   $y�	Collapsed=�6>   $��50��6U   $��50��6a   $
��Left=�6l   $	��Top=�6�   #��[ 6�   ���	#FF31577E��6�   Z� ��6�   Z� .��5V   "     $
 Menu=�6:   $��30��6F   $��30��6Q   5W      o� 5X      
������ $��0,10,0,0q�6>   ��5Y   "   �� 5Z   &   .R�5[   *   $�  $� Orientation$ Vertical=�6A   6Z   5\   '   .@�5_   "   m� -   5        $��Trang chủ��5_   +   $	��200��6>   $��Arial)�6K   $
��Bold"�6^   $��13(�6q    � ForceCursor$
 True��6    m� Icon 5`   &     5a   *   $��28��6B   $��28��6M   $
 Home=�6Y   $��-8.45,-9,0,0q�6f   ��5b   .   �� 5c   2    �� EndPoint$ 0.5,1&�6F    �� 
StartPoint$ 0.5,0&�6W   .��5d   6   �  � Color$ Black��6C   � 5e   6   $ 	#FFD371F0��6C    � Offset$ 1Q�6U   � 5f   6   $ 	#FF512B5C��6C   $ 0.387Q�6U   � 5g   6   $ 	#FF4F2A5A��6C   $ 0.501Q�6U   5h   3   5j   +   5l   #   m� 5m   "   -   5        $��Tìm việc��5m   +   $	��200��6=   $��Arial)�6J   $
��Bold"�6]   $��13(�6p   $
 True��6~    5n   &     5o   *   $��28��6B   $��28��6M   $ Magnify=�6Y   $��	-7,-8,0,0q�6i   ��5p   .   �� 5q   2   $ 0.5,1&�6F   $ 0.5,0&�6W   .��5r   6   � $ Black��6C   � 5s   6   $ 	#FFD371F0��6C   $ 1Q�6U   � 5t   6   $ 	#FF512B5C��6C   $ 0.387Q�6U   � 5u   6   $ 	#FF4F2A5A��6C   $ 0.501Q�6U   5v   3   5x   +   5z   #   m� 5{   "   -   5        $��Danh sách việc làm��5{   +   $	��200��6H   $��Arial)�6U   $
��Bold"�6h   $��13(�6{   $
 True��6�    5|   &     5}   *   $��28��6B   $��24��6M   $ ListBoxOutline=�6Y   $��
-7,-6,0,-3q�6o   $��Stretch=�6�   ��5~   .   �� 5   2   $ 0.5,1&�6F   $ 0.5,0&�6W   .��5�   6   � $ Black��6C   � 5�   6   $ 	#FFD371F0��6C   $ 1Q�6U   � 5�   6   $ 	#FF512B5C��6C   $ 0.387Q�6U   � 5�   6   $ 	#FF4F2A5A��6C   $ 0.501Q�6U   5�   3   5�   +   5�   #   m� 5�   "   -	   5        $��Thống kê công việc��5�   +   $	��200��6H   $��Arial)�6V   $
��Bold"�6i   $��13(�6|   $
 True��6�    5�   &     5�   *   $��26��6B   $��24��6M   $ 
ListStatus=�6Y   $��-6,0,0,0q�6l   $��Center=�6~   ��5�   .   �� 5�   2   $ 0.5,1&�6F   $ 0.5,0&�6W   .��5�   6   � $ Black��6C   � 5�   6   $ 	#FFD371F0��6C   $ 1Q�6U   � 5�   6   $ 	#FF512B5C��6C   $ 0.387Q�6U   � 5�   6   $ 	#FF4F2A5A��6C   $ 0.501Q�6U   5�   3   5�   +   5�   #   m� 5�   "   -
   5         m�Name$ 	mnuLogout��5�   +   $	��200��6?   $��Đăng xuất��6M   $��Arial)�6`   $
��Bold"�6s   $��13(�6�   $
 True��6�   $��0,300q�6�    5�   &     5�   *   $��26��6B   $��24��6M   $ Logout=�6Y    � IsSharedSizeScope$
 True��6h   $��0,-5,0,0q�6�   $��Center=�6�   ��5�   .   �� 5�   2   $ 0.5,1&�6F   $ 0.5,0&�6W   .��5�   6   � $ Black��6C   � 5�   6   $ 	#FFD371F0��6C   $ 1Q�6U   � 5�   6   $ 	#FF512B5C��6C   $ 0.387Q�6U   � 5�   6   $ 	#FF4F2A5A��6C   $ 0.501Q�6U   5�   3   5�   +   5�   #   5�      5�      5�      5�      5�      5�      5�      5�      