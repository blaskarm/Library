   M S B A M L   `   `   `  ����B  >Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Library.Pages.MemberPagesLibrary.Pages.MemberPages  5      ,    &Library.Pages.MemberPages.SettingsPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:Library.Pages.MemberPages     5        N� Title$  SettingsPage��5	       N� 
FontFamily$ Arial)�6    N� 
Background �#e6e6e6 N� 
Foreground �#404040 � 	Resources 5         	BoolToVis��%   &	        �� 5   
   6'   5      .��5      �� .+�5   
   �� $��Settings��6   $��24(�6$   $��
20 0 20 30q�62   �� 5   
   $��	25 0 20 5q�6.   $��14(�6A   ��6   �� *
FullName+6A   � 5   
   $	��250��6   $
��Left=�6   $��
20 0 20 20q�66   .+�5      �� $
��20 0q�6   $��Center=�6&   ���#b0b9c6 J� IsHitTestVisible$ False��6V    K� ZIndex$ 1��5       $��Change Name��61   y�5       ��  �� ElementName$ 
changeName�� �� Path$ Text.IsEmpty�	 �� 	Converter#	 [  �� 5      -   5        
 ��Name$
 
changeName��5        textboxSearch#��[ 6*   5      �� 5   
   $��	25 0 20 5q�6+   $��14(�6>   ��6   �� *Email+6>   � 5   
   $	��250��6   $
��Left=�6   $��
20 0 20 20q�66   .+�5      �� $
��20 0q�6   $��Center=�6&   ���#b0b9c6$ False��6V   $ 1��5        $��Change Email��61   y�5!       �� $ changeEmail��$ Text.IsEmpty�#	 [  �� 5#      -   5        $
 changeEmail��5#      #��[ 6+   5$      �� 5&   
   $��New Password��6   $��	25 0 20 5q�6(   $��14(�6;   � 5'   
   $	��250��6   $
��Left=�6   $��	20 0 20 5q�66   .+�5(      �� $
��20 0q�6   $��Center=�6&   ���#b0b9c6$ False��6V   $ 1��5)      $��Change Password��6)   y�5*      �� $ newPassword��$ Text.IsEmpty�#	 [  �� 5,      -   5        $
 newPassword��5,      #��[ 6+   5-      � 5/   
   $	��250��6   $
��Left=�6   $��
20 0 20 20q�66   .+�50      �� $
��20 0q�6   $��Center=�6&   ���#b0b9c6$ False��6V   $ 1��51      $��Confirm Password��6!   y�52      �� $ confirmPassword��$ Text.IsEmpty�#	 [  �� 54      -   5        $
 confirmPassword��54      #��[ 6/   55      �� 57   
   -   5         ��Name$ 
saveButton��57      $��Save Changes��6?   $	��100��6V   $��30��6b     RoundedButtonStyle#���  6n   $
��Left=�58   	   $��	170 0 0 0q�59   	   5:      5=      