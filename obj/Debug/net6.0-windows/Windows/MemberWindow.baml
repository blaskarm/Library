   M S B A M L   `   `   `  ����B  >Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Library.WindowsLibrary.Windows  5   	   "    Library.Windows.MemberWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	   +localclr-namespace:Library.Windows   5   	     � Title$  Library��5	   	   $	��600��6   $
��1000��6&   $��Arial)�63    � WindowStartupLocation$ CenterScreen=�6F    � 
ResizeMode$ CanMinimize=�5
   	   ���#e6e6e6���#404040 � 	Resources 5         	BoolToVis��%   &	        �� 5   
   6'   5      .��5      �  � RowDefinitions 5   
   �� 5      $��70 �6   �� 5      $��* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� -   5         ��Name$ logoutButton��5      $��Logout��6F   $	��100��6W   $��30��6c   $��
10 10 2 10q�6o   $��5q�6�     RoundedButtonStyle#���  6�   5      �� 5      $��Library Management��6   $��Center=�62   $��20 0 0 0q�6M   $��16(�6_    �� Padding$ 5q�6m   5      � 5    
   $��1��6    � ColumnDefinitions 5"      �� 5#      $	��200 �6#   �� 5$      $��* �6#   .+�5'      �� .+�5(      �� -   5        $ libraryButton��5(      $��Show Library��60   #���  6G   $��8q�6t   $��
10 50 10 5q�6�   5)      �� 5+      -   5        $ favoritesButton��5+      $��	Favorites��62   #���  6F   $��8q�6s   $��	10 0 10 5q�6   5,      �� 5.      -   5        $ borrowedButton��5.      $��Borrowed��61   #���  6D   $��8q�6q   $��	10 0 10 5q�6}   5/      �� 51      -   5        $ settingsButton��51      $��Settings��61   #���  6D   $��8q�6q   $��	10 0 10 5q�6}   52      55       � 57      -   5        	  �Name$	 
booksFrame��57      $��1��6(   $��1��65   
  � NavigationUIVisibility$
 Hidden=�6E    � 58      -   5        $	 bookInfoFrame��58      $��1��6+   $��1��68   $
 Hidden=�6H    � 59      -   5        $	 favoritesFrame��59      $��1��6,   $��1��69   $
 Hidden=�6I    � 5:      -	   5        $	 borrowedFrame��5:      $��1��6+   $��1��68   $
 Hidden=�6H    � 5;      -
   5        $	 settingsFrame��5;      $��1��6+   $��1��68   $
 Hidden=�6H   5>      5A      5D      