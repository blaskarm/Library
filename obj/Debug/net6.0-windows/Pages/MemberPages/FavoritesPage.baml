   M S B A M L   `   `   `  ����B  >Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Library.Pages.MemberPagesLibrary.Pages.MemberPages  5      -    'Library.Pages.MemberPages.FavoritesPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:Library.Pages.MemberPages     5        N� Title$  FavoritesPage��5	       N� 
FontFamily$ Arial)�6    N� 
Background �#e6e6e6 N� 
Foreground �#404040.��5      �  � RowDefinitions 5   
   �� 5      $��35 �6   �� 5      $��* �6   .+�5   
   �� $��	Favorites��6   $��24(�6%   $��	20 0 20 0q�63   �� 5   
   $��
20 0 20 20q�6   $��1��6%   ._�5      &   System.Windows.Controls.DataGrid  -   5          Name$ favoritesDataGrid��5         SelectionMode$ Single=�62   $|�False��6I      DataGridStyle1#���   6[     DataGridCellStyle1   	CellStyle# �  5        DataGridColumnHeaderStyle1   ColumnHeaderStyle# �  6H     DataGridRowStyle1	   RowStyle#	 �  5      
   Columns
 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Title��6-      
IsReadOnly$
 True��6<      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6N      CellTemplate 5      �� 5      .R�5   "   �� ��6,   �� *Title+5      5!        5$      $ Author��6-   $
 True��6=   $ * 6O    5%      �� 5&      .R�5'   "   �� ��6,   �� *Author.FullName+5(      5*        5-      $ 	Published��6-   $
 True��6@   $ * 6R    5.      �� 5/      .R�50   "   �� ��6,   �� *PublishedString+51      53        56      $ Available Copies��6-   $
 True��6G   $ * 6Y    57      �� 58      .R�59   "   �� ��6,   �� *AvailableCopies+5:      5<      5@      5B      5D      5G      