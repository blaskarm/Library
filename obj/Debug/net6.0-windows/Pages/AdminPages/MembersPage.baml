   M S B A M L   `   `   `  ����B  >Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:Library.Pages.AdminPagesLibrary.Pages.AdminPages  5      *    $Library.Pages.AdminPages.MembersPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:Library.Pages.AdminPages     5        N� Title$  MembersPage��5	       N� 
Background �#404040 N� 
Foreground �#e6e6e6 N� 
FontFamily$ Arial)�6E   .��5      �  � RowDefinitions 5   
   �� 5      $��35 �6   �� 5      $��* �6   .+�5   
   �� $��Members��6   $��24(�6#   $��	20 0 20 0q�61   �� 5   
   $��
20 0 20 20q�6   $��1��6%   ._�5      &   System.Windows.Controls.DataGrid  -   5          Name$ membersDataGrid��5         SelectionMode$ Single=�60   $|�False��6G      DataGridStyle1#���   6Y     DataGridCellStyle1   	CellStyle# �  5        DataGridColumnHeaderStyle1   ColumnHeaderStyle# �  6D     DataGridRowStyle1	   RowStyle#	 �  5      
   Columns
 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6-      
IsReadOnly$
 True��6;      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6M      CellTemplate 5      �� 5      .R�5   "   �� ��6,   �� *
FullName+5      5         5#      $ Email��6-   $
 True��6<   $ * 6N    5$      �� 5%      .R�5&   "   �� ��6,   �� *Email+5'      5)      5-      5/      50      51      