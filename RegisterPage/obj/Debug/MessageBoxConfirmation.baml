   M S B A M L   `   `   `  ����G  CRegisterPage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:RegisterPage.Properties.LangsRegisterPage.Properties.Langs  5   	   )    #RegisterPage.MessageBoxConfirmation   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @language+clr-namespace:RegisterPage.Properties.Langs     5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  MessageBoxWindow��5   	   $	��197��6"   $	��315��6/    � WindowStartupLocation$ CenterScreen=�5	   	    � WindowStyle$
 None=�6.   
������ 
������  � AllowsTransparency .  � 
ResizeMode$ NoResize=�5   	    � Topmost .   � ShowInTaskbar . $��Regular"�5   	   $��10(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	      MaterialDesignFont#���   5   	   .��5      � 	 � ColumnDefinitions	 5   
   �� 5      $
��197* �6   �� 5      $
��295* �6   
 � RowDefinitions
 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� 
������ 6   � 5!   
   $��1��6   $��2��6   .+�5#      �� 
������ 6   �� 5%       �� CornerRadius$ 15��6   
������ ��5&      �� 5'       �� 
StartPoint$ 0,0.5&�6*    �� EndPoint$ 1,0.5&�6=   .��5(      �  � Color$ #FFDE59��6'    � Offset$ -0.50Q�67   � 5)      $ #FF66C4��6'   $ 1Q�67   5*      5,      �� 5.      $��Right=�6   $��0,5,5,0q�66   $	��Top=�6H   $��1��6`   .+�5/      �� -   5         ��Name$ buttonClose��5/      $��25��6H   $��25��6S   
�������  PrimaryHueDarkBrush#���  6s    * &MaterialDesignFloatingActionDarkButton#��[ 6�   .��50      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�6.   51      52      � 56      $��20,45,20,10q�6   
 59      �� 5:      $
��auto �6$   �� 5;      $
��auto �6$   �� 5<      $��* �6$   .+�5?      � $��1��6   
 5@      �� 5A      $
��auto �6(   �� 5B      $��* �6(   .+�5E      �� 
������ 6   �� 5H      -   5         ��Name$ textBoxMessage��5H        �� TextAlignment$ Center=�68   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$  ��5I       $��24(�6B   $
��Wrap=�5J       ���#545454$%��Gill Sans MT Ext Condensed Bold)�5K       $��2��5L       $��5,21,-5,-51q�61   Are you sure?5N      5P      � 5R      $��1��6   $��
0,94,0,-12q�6$   $��2��68   	 5S      �� 5T      $��* �6+   �� 5U      $
��auto �6+   �� 5V      $
��auto �6+   �� 5W      $��* �6+   .+�5Z      �� 
������ 6   �� 5\      -   5        $ buttonAccept��5\      $��1��6N    # MaterialDesignRaisedLightButton#��[ 5]   !   $��5q�5^   !   $	��100��6,    � ToolTip$ Accept��68   
������ .��5_      �� $��12(�6$   $��Accept��62   ��5`      �� 5a      $ 0,0.5&�62   $ 1,0.5&�6E   .��5b   "   � $ #FF83C6��6/   $	 0.0Q�6?   � 5c   "   $ #8C6CFF��6/   $ 1Q�6?   5d      5f      �� 5h      -   5        $ buttonCancel��5h      $��2��6N   #��[ 5i   !   $��5q�5j   !   $	��100��6,   $ Cancel��68   
������ .��5k      �� $��12(�6$   $��Cancel��62   ��5l      �� 5m      $ 0,0.5&�62   $ 1,0.5&�6E   .��5n   "   � $ #FF83C6��6/   $	 0.0Q�6?   � 5o   "   $ #8C6CFF��6/   $ 1Q�6?   5p      5r      �� 5t      -   5        $ buttonOk��5t      $��1��6F   #��[ 5u   !   $��5q�5v   !   $	��100��6,   $ Ok��68   
������ .��5w      �� $��Ok��6$   ��5x      �� 5y      $ 0,0.5&�62   $ 1,0.5&�6E   .��5z   "   � $ #FF83C6��6/   $	 0.0Q�6?   � 5{   "   $ #8C6CFF��6/   $ 1Q�6?   5|      5~      5�      5�      5�      5�      5�      