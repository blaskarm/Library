   M S B A M L   `   `   `  ����B  >Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:Library.Pages.AdminPagesLibrary.Pages.AdminPages  5      *    $Library.Pages.AdminPages.AddBookPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:Library.Pages.AdminPages     5        N� Title$  AddBookPage��5	       N� 
FontFamily$ Arial)�6    N� 
Background �#404040 N� 
Foreground �#e6e6e6.��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��40 0 0 0q�6   .+�5      �� $��Add Book��6   $��26(�6(   $
��Bold"�66   �� 5      $��Title��6   $��18(�6%   $��0 30 0 0q�63    J� Opacity$	 0.8Q�6E   �� 5      -   5         ��Name$ bookTitleTextbox��5      $	��250��60   $
��Left=�6<   $��5q�6W   �� 5      $��Author��6   $��18(�6&   $��0 20 0 0q�64   $	 0.8Q�6F   �� 5      -   5        $ authorTextbox��5      $	��250��6-   $
��Left=�69   $��5q�6T   �� 5       $��Pages��6   $��16(�6%   $��0 20 0 0q�63   $	 0.8Q�6E   �� 5!      -   5        $ pagesTextbox��5!      $	��250��6,   $
��Left=�68   $��5q�6S   �� 5#      $��Available Copies��6   $��16(�60   $��0 20 0 0q�6>   $	 0.8Q�6P   �� 5$      -   5        $ availableCopiesTextbox��5$      $	��250��66   $
��Left=�6B   $��5q�6]   �� 5&      $��	Published��6   $��16(�6)   $��0 20 0 0q�67   $	 0.8Q�6I   �� 5(       �� Orientation$ 
Horizontal=�6   .+�5)      &   System.Windows.Controls.Calendar  -   5          Name$ bookCalendar��5)      $
��Left=�61   	   DisplayMode$	 Decade=�6L   �� 5+      -   5        
 ��Name$
 addBookButton��5+         RoundedButtonStyle#���   60   $��Add Book��6]   $	��100��5,      $��22��6%   $��Bottom=�6M   $��40 0 0 0q�5-      5.      50      �� 52   
   $��40 0 0 0q�6   $��1��6'   .+�54      �� $��
Add Author��6   $��26(�6*   $
��Bold"�68   �� 56      $
��Name��6   $��18(�6$   $��0 30 0 0q�62   $	 0.8Q�6D   �� 57      -   5        $ authorNameTextbox��57      $	��250��61   $
��Left=�6=   $��5q�6X   �� 5<      $��Nationality��6   $��16(�6+   $��0 20 0 0q�69   $	 0.8Q�6K   �� 5=      -   5        $ nationalityTextbox��5=      $	��250��62   $
��Left=�6>   $��5q�6Y   �� 5?      $��	Birthdate��6   $��16(�6)   $��0 20 0 0q�67   $	 0.8Q�6I   �� 5@      $ 
Horizontal=�6   .+�5A        -	   5        $ authorCalendar��5A      $��	0 20 40 0q�63   $	 Decade=�6F   �� 5C      -
   5        $
 addAuthorButton��5C      #���   62   $��
Add Author��6_   $	��100��5D      $��22��6%   $��Bottom=�6O   5E      5G      5I      5J      