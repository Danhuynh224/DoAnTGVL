   M S B A M L   `   `   `  ����C  ?DoAnTGVL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:DoAnTGVL.UControlsDoAnTGVL.UControls  5   	   #clr-namespace:DoAnTGVLDoAnTGVL  5   	   7 clr-namespace:DoAnTGVL.UControlsDoAnTGVL.UControls  5	   	   7 clr-namespace:DoAnTGVL.UControlsDoAnTGVL.UControls  5
   	       DoAnTGVL.UserMain   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   ,local clr-namespace:DoAnTGVL.UControls  5   	   &	UCThueThoclr-namespace:DoAnTGVL  5   	   0	UCDangBai clr-namespace:DoAnTGVL.UControls  5	   	   1
UCTrangChu clr-namespace:DoAnTGVL.UControls  5
   	     � Title$  UserMain��5   	   $	��800��6   $
��1500��6'    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	    � 	Resources 5         OpenMenu �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  	CloseMenu��%S  &	        &	 �     �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ gridMainmenu��6a   .\�5        $ 0:0:0.3��6'   $	 200Q�69   5      5      �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ gridMainmenu��6a   .\�5        $ 0:0:0.3��6'   $ 50Q�69   5      5      5       � Triggers 5      :� 5   
   	 :� RoutedEvent$	 ButtonBase.Click��6   
 :� 
SourceName$
 ButtonOpenMenu��66   .[�5       �� #��[  6   5!      :� 5"   
   $	 ButtonBase.Click��6   $
 ButtonCloseMenu��66   .[�5#      �� #��[ 6   5$      :� 5%   
   $	 UIElement.MouseLeave��6   $
 gridMainmenu��6:   .[�5&      �� #��[ 6   5'      .��5)      � -   5         �Name$ gridMain��5)       � ColumnDefinitions 5*   
   .+�5,   
   � -   5        $ gridMainWin��5,      $��Right=�6$   $
��1450��6@   5.      � 5/   
   -   5        $ gridMainmenu��5/      $��50��6%   $
��Left=�60   .+�50      �� ���#CCCCCC$��1q�6+   ���#FFFFFF �� CornerRadius$ 5��6T   $
��Left=�6e    J� Effect 51      3  -System.Windows.Media.Effects.DropShadowEffect  52         ShadowDepth$ 0Q�6'      
BlurRadius$ 10Q�67      Opacity$	 0.7Q�6G      Color$ Black��6U   ._�54      � z�55      V� 56      .~�57      �� �� 58      �� 59      T� 5:      5;      .+�5=      �� $��0��6"    �� Orientation$ Vertical=�62   $��Stretch=�6I   ���#FFFFFF.+�5?      �� .+�5@      �� -   5         ��Name$ ButtonOpenMenu��5@   %   $��50��6=   $��50��6I   $��0q�6T   $
��Left=�6_   $	��Top=�6z    0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 6�   ���	#FF31577E��6�   Z� ��6�   Z� .��5A   "   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Menu=�6:   $��30��6F   $��30��6Q   5B      �� 5C      -   5        $ ButtonCloseMenu��5C   %   $y�	Collapsed=�6>   $��50��6U   $��50��6a   $
��Left=�6l   $	��Top=�6�   #��[ 6�   ���	#FF31577E��6�   Z� ��6�   Z� .��5D   "     $
 Menu=�6:   $��30��6F   $��30��6Q   5E      o� 5F      
������ $��0,10,0,0q�6>   ��5G   "   �� 5H   &   .R�5I   *   $�  $� Orientation$ Vertical=�6A   6Z   5J   '   .@�5M   "   m� -   5        $��Trang chủ��5M   +   $	��200��6>   $��Arial)�6K   $
��Bold"�6^   $��13(�6q    � ForceCursor$
 True��6    m� Icon 5N   &     5O   *   $��28��6B   $��28��6M   $
 Home=�6Y   $��	-7,-8,0,0q�6f   ��5P   .   �� 5Q   .    �� EndPoint$ 0.5,1&�6B    �� 
StartPoint$ 0.5,0&�6S   .��5R   2   �  � Color$ Black��6?   � 5S   2   $ 	#FFD371F0��6?    � Offset$ 1Q�6Q   � 5T   2   $ 	#FF512B5C��6?   $ 0.387Q�6Q   � 5U   2   $ 	#FF4F2A5A��6?   $ 0.501Q�6Q   5V   /   5X   +   5Z   #   m� 5[   "   -   5        $��
Tìm thợ��5[   +   $	��200��6<   $��Arial)�6I   $
��Bold"�6\   $��13(�6o   $
 True��6}    5\   &     5]   *   $��28��6B   $��28��6M   $ Magnify=�6Y   $��	-7,-8,0,0q�6i   ��5^   .   �� 5_   2   $ 0.5,1&�6F   $ 0.5,0&�6W   .��5`   6   � $ Black��6C   � 5a   6   $ 	#FFD371F0��6C   $ 1Q�6U   � 5b   6   $ 	#FF512B5C��6C   $ 0.387Q�6U   � 5c   6   $ 	#FF4F2A5A��6C   $ 0.501Q�6U   5d   3   5f   +   5h   #   m� 5i   "   -   5        $��Tiến độ��5i   +   $	��200��6=   $��Arial)�6J   $
��Bold"�6]   $��13(�6p   $
 True��6~    5j   &     5k   *   $��26��6B   $��25��6M   $ ProgressAlert=�6Y   $��	-7,-6,0,0q�6o   ��5l   .   �� 5m   2   $ 0.5,1&�6F   $ 0.5,0&�6W   .��5n   6   � $ Black��6C   � 5o   6   $ 	#FFD371F0��6C   $ 1Q�6U   � 5p   6   $ 	#FF512B5C��6C   $ 0.387Q�6U   � 5q   6   $ 	#FF4F2A5A��6C   $ 0.501Q�6U   5r   3   5t   +   5v   #   m� 5w   "   $��
Hóa Đơn��6+   $	��200��6=   $��Arial)�6K   $
��Bold"�6^   $��13(�6q   $
 True��6    5x   &     5y   *   $��26��6B   $��24��6M   $ Receipt=�6Y   $��-6,0,0,0q�6i   $��Center=�6{   ��5z   .   �� 5{   2   $ 0.5,1&�6F   $ 0.5,0&�6W   .��5|   6   � $ Black��6C   � 5}   6   $ 	#FFD371F0��6C   $ 1Q�6U   � 5~   6   $ 	#FF512B5C��6C   $ 0.387Q�6U   � 5   6   $ 	#FF4F2A5A��6C   $ 0.501Q�6U   5�   3   5�   +   5�   #   m� 5�   "   -	   5        $��Theo dõi bài đăng��5�   +   $	��300��6G   $��Arial)�6U   $
��Bold"�6i   $��13(�6|   $
 True��6�    5�   &     5�   *   $
 Post=�6B   $��26��6N   $��24��6Y   $��-6,0,0,0q�6f   $��Center=�6x   ��5�   .   �� 5�   2   $ 0.5,1&�6F   $ 0.5,0&�6W   .��5�   6   � $ Black��6C   � 5�   6   $ 	#FFD371F0��6C   $ 1Q�6U   � 5�   6   $ 	#FF512B5C��6C   $ 0.387Q�6U   � 5�   6   $ 	#FF4F2A5A��6C   $ 0.501Q�6U   5�   3   5�   +   5�   #   m� 5�   "   $��Đánh Giá��6+   $	��200��6>   $��Arial)�6K   $
��Bold"�6^   $��13(�6q   $
 True��6    5�   &     5�   *   $��26��6B   $��26��6M   $ ThumbsUp=�6Y   $��	-6,-7,0,0q�6j   ��5�   .   �� 5�   2   $ 0.5,1&�6F   $ 0.5,0&�6W   .��5�   6   � $ Black��6C   � 5�   6   $ 	#FFD371F0��6C   $ 1Q�6U   � 5�   6   $ 	#FF512B5C��6C   $ 0.387Q�6U   � 5�   6   $ 	#FF4F2A5A��6C   $ 0.501Q�6U   5�   3   5�   +   5�   #   m� 5�   "   -
   5         m�Name$ 	mnuLogout��5�   +   $	��200��6?   $��Đăng xuất��6M   $��Arial)�6`   $
��Bold"�6s   $��13(�6�   $
 True��6�   $��0,300q�6�    5�   &     5�   *   $��26��6B   $��24��6M   $ Logout=�6Y    � IsSharedSizeScope$
 True��6h   $��0,-5,0,0q�6�   $��Center=�6�   ��5�   .   �� 5�   2   $ 0.5,1&�6F   $ 0.5,0&�6W   .��5�   6   � $ Black��6C   � 5�   6   $ 	#FFD371F0��6C   $ 1Q�6U   � 5�   6   $ 	#FF512B5C��6C   $ 0.387Q�6U   � 5�   6   $ 	#FF4F2A5A��6C   $ 0.501Q�6U   5�   3   5�   +   5�   #   5�      5�      5�      5�      5�      5�      5�      5�      