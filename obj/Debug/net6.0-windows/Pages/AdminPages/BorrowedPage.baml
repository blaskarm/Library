   M S B A M L   `   `   `  ����B  >Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:Library.Pages.AdminPagesLibrary.Pages.AdminPages  5      +    %Library.Pages.AdminPages.BorrowedPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:Library.Pages.AdminPages     5        N� Title$  BorrowedPage��5	       N� 
Background �#404040 N� 
Foreground �#e6e6e6 N� 
FontFamily$ Arial)�6F   .��5      �  � RowDefinitions 5   
   �� 5      $��35 �6   �� 5      $��* �6   .+�5   
   �� $��Borrowed Books��6   $��24(�6*   $��	20 0 20 0q�68   �� 5   
   $��
20 0 20 20q�6   $��1��6%   ._�5      &   System.Windows.Controls.DataGrid  -   5          Name$ borrowedDataGrid��5         SelectionMode$ Single=�61   $|�False��6~      DataGridStyle1#���   6�     DataGridCellStyle1   	CellStyle# �  5        DataGridColumnHeaderStyle1   ColumnHeaderStyle# �  6D     DataGridRowStyle1	   RowStyle#	 �  5      
   Columns
 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Title��6-      
IsReadOnly$
 True��6<      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6N      CellTemplate 5      �� 5      .R�5   "   �� ��6,   �� *Title+5      5         5#      $ Author��6-   $
 True��6=   $ * 6O    5$      �� 5%      .R�5&   "   �� ��6,   �� *Author.FullName+5'      5)        5,      $ 	Published��6-   $
 True��6@   $ * 6R    5-      �� 5.      .R�5/   "   �� ��6,   �� *PublishedString+50      52        55      $ Available Copies��6-   $
 True��6G   $ * 6Y    56      �� 57      .R�58   "   �� ��6,   �� *AvailableCopies+59      5;      5?      5A      5B      5C      