   M S B A M L   `   `   `  ����C  ?DoAnTGVL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:DoAnTGVL.UControlsDoAnTGVL.UControls  5      +    %DoAnTGVL.UControls.UCUserChuaThucHien   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:DoAnTGVL.UControls     5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      $��Roboto)�5	   
   .��5      � ���#FFFFFF.+�5      � .+�5   
   � ���#F2F1F1$	��500��6%   $
��1100��62   $��Center=�6?   $	��Top=�6\   $��0 20 0 0q�6t     J� Clip  5      �� 5       �� Rect$ 0,0,1100,500�6%    �� RadiusX$ 10Q�69    �� RadiusY$ 10Q�6F   5      .+�5      �� $��Disabled=�6    �� View 5      �� 5      ! �� ColumnHeaderContainerStyle 5      �� 5       �� 
TargetType" ��6$   .�5   "   ��  �� Property � �� �� Value
 ��ح�6?   �� 5   "    � ��
 �   �6?   �� 5   "    � ��$
 Bold"�6?   5      .P�5      �� 	 �� Width$		 120��6)   $��Tên công việc��65   �� 5       $		 200��6)   $��Tên thợ thực hiện��65   �� 5"      $		 200��6)   $��
Ngày làm��65   �� 5$      $		 150��6)   $��Trạng thái��65   �� 5&      $
	 140 ��6)   $��Số lượng thợ��66   �� 5(      $��Sửa��6)   $		 150��66   
 �� CellTemplate
 5)      �� 5*   "   .R�5+   &   ��    MaterialDesignToolButton#��[  6-   $��75��5,   %   $
��Auto��5-   %   $��10q�5.   %   $��Sửa��5/   %   50   #   52      �� 54      $
��Xóa��6)   $
	 150 ��66   
 55      �� 56   "   .R�57   &   �� #��[  6-   $��75��58   "   $
��Auto��59   "   $��10q�5:   "   $
��Xóa��5;   "   5<   #   5>      5@      5D      5E      5G      5H      5I      