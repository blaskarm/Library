   M S B A M L   `   `   `  ����B  >Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Library.WindowsLibrary.Windows  5   	   !    Library.Windows.AdminWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	   +localclr-namespace:Library.Windows   5   	     � Title$  Administrator��5	   	   $	��650��6   $
��1000��6,    � WindowStartupLocation$ CenterScreen=�69    � 
ResizeMode$ CanMinimize=�6^   ���#e6e6e6���#404040$��Arial)�5
   3    � 	Resources 5         	BoolToVis��%   &	        �� 5   
   6'   5      .��5      �  � RowDefinitions 5   
   �� 5      $��70 �6   �� 5      $��* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� -   5         ��Name$ logoutButton��5      $��Logout��6G   $	��100��6X   $��30��6d   $��
10 10 2 10q�6p   $��5q�6�     RoundedButtonStyle#���  5      ���#e6e6e65      �� 5      $��Library Management��6   $��Center=�62   $��20 0 0 0q�6M   $��16(�6_    �� Padding$ 5q�6m   5      �� 5!   
   $ 
Horizontal=�6   $��Right=�6.   .+�5"      �� $��Center=�62   $��16(�6M   $ 5q�6[   $��0 0 30 0q�6g   ��6   �� *
FullName+6g   5#      � 5%   
   $��1��6    � ColumnDefinitions 5'      �� 5(      $	��200 �6#   �� 5)      $��* �6#   .+�5,      �� .+�5-      �� -   5        $ libraryButton��5-      $��Books��60   #���  6@   $��8q�6m   $��
10 50 10 5q�6y   ���#e6e6e65.   5   �� 50      -   5        $ authorsButton��50      $��Authors��60   #���  6B   $��8q�6o   $��	10 0 10 5q�6{   ���#e6e6e651   6   �� 53      -   5        $ addBookButton��53      $��Add Recourses��60   #���  6H   $��8q�6u   $��	10 0 10 5q�6�   ���#e6e6e654   5   �� 56      -   5        $ borrowedButton��56      $��Borrowed��61   #���  6D   $��8q�6q   $��	10 0 10 5q�6}   ���#e6e6e657   6   �� 59      -   5        $ membersButton��59      $��Members��60   #���  6B   $��8q�6o   $��	10 0 10 5q�6{   ���#e6e6e65:   6   5=       � 5?      -   5        	  �Name$	 
booksFrame��5?      $��1��6(   
  � NavigationUIVisibility$
 Hidden=�68    � 5@      -   5        $	 bookInfoFrame��5@      $��1��6+   $
 Hidden=�6;    � 5A      -	   5        $	 addBookFrame��5A      $��1��6*   $
 Hidden=�6:    � 5B      -
   5        $	 borrowedFrame��5B      $��1��6+   $
 Hidden=�6;    � 5C      -   5        $	 membersFrame��5C      $��1��6*   $
 Hidden=�6:    � 5D      -   5        $	 authorsFrame��5D      $��1��6*   $
 Hidden=�6:    � 5E      -   5        $	 authorInfoFrame��5E      $��1��6-   $
 Hidden=�6=   5H      5K      5N      