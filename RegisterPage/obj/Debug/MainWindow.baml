   M S B A M L   `   `   `  ����G  CRegisterPage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:RegisterPageRegisterPage  5   	   M+clr-namespace:RegisterPage.Properties.LangsRegisterPage.Properties.Langs  5   	       RegisterPage.MainWindow   5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5
   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:RegisterPage     5   	   @language+clr-namespace:RegisterPage.Properties.Langs     5   	      MaterialDesignBody#���   5   
   $��Regular"�5   
   $��13(�5   
   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   
      TextRenderingMode$
 Auto=�5   
     MaterialDesignPaper#���  5   
     MaterialDesignFont#���  5	   
    � Title$ Register Page��5   	   $	��700��6   $
��1000��6,    � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode$ NoResize=�6.   .��5      � ��5   
   �� 5       �� 
StartPoint$ 0,0.5&�6"    �� EndPoint$ 1,0.5&�65   .��5      �  � Color$ #FF83C6��6    � Offset$	 0.1Q�6/   � 5      $ #8C6CFF��6   $ 1Q�6/   5      .+�5   
   �� (   "RegisterPage.Properties.Langs.Lang	   titleNew#��Z	 6   $��65(�6<   $��Center=�5      $%��Gill Sans MT Ext Condensed Bold)�6-   $��Center=�6Z   $
��Bold"�5      $��386,0,368,549q�6"   $	��238��69   ���#5454546E   �� 5    
   
   titleAccount#��Z
 6   $��65(�6@   $��Center=�5!      $%��Gill Sans MT Ext Condensed Bold)�6-   $��Center=�6Z   $
��Bold"�5"      $��367,62,343,526q�6"   $	��284��6:   ���#5454546F   �� 5$   
   -   5        $��textBoxName��5$      $��2q�6%   $
��Left=�69   $��55��5%      $��282,199,0,0q�6    �� TextWrapping$
 Wrap=�63   $	��Top=�5&      $	��182��6*   
�������$��10, 8, 10, 0q�5'   &   .  (MaterialDesignThemes.Wpf.TextFieldAssist   HasClearButton .  % !MaterialDesignFloatingHintTextBox#��[ 5)         TextFieldCornerRadius$ 5��5*         name)  #MaterialDesignThemes.Wpf.HintAssist   Hint# Z 5+      ��5&   6   Z� .��5+   Q    � 	Resources 5,      (  "MaterialDesignThemes.Wpf.SmartHint �� 
TargetType �� Property �� Value��%�   '        �� 5-      "  6   .�5.      ��  � ��$ Center=�6<   �� 5/       � ��
 �����63   �� 50       �@J�Opacity$ 1Q�60   51      52      .��6!   53      �� 55   
   -   5        $��textBoxLastName��55      $��2q�6)   $
��Left=�6=   $��55��56      $��282,299,0,0q�6   $
 Wrap=�6.   $	��Top=�57      $	��182��6%   
�������$��10, 8, 10, 0q�58   !    . $ 5��5:         lastName# Z 5;      ��57   1   Z� .��5;   P    5<      ��%�   '        �� 5=      "  6   .�5>      ��  � ��$ Center=�6<   �� 5?       � ��
 �����63   �� 5@       �@J�Opacity$ 1Q�60   5A      5B      .��6!   ��5C      �� 5D       �� ResourceKey$' !MaterialDesignFloatingHintTextBox��6!   .��5E      5F      �� 5H   
   -   5        $��textBoxEmail��5H      $��2q�6&   $
��Left=�6:   $��55��5I      $��282,399,0,0q�6   $
 Wrap=�6.   $	��Top=�5J      $	��182��6%   
�������$��10, 8, 10, 0q�5K   !    . $ 5��5M         email# Z 5N      ��5J   1   Z� .��5N   M    5O      ��%�   '        �� 5P      "  6   .�5Q      ��  � ��$ Center=�6<   �� 5R       � ��
 �����63   �� 5S       �@J�Opacity$ 1Q�60   5T      5U      .��6!   ��5V      �� 5W      $' !MaterialDesignFloatingHintTextBox��6!   .��5X      5Y      �� 5[   
   -   5        $��textBoxPassword��5[      $��2q�6)   $
��Left=�6=   $��55��5\      $��538,199,0,0q�6   $
 Wrap=�6.   $	��Top=�5]      $	��182��6%   
�������$��10, 8, 10, 0q�5^   !    . $ 5��5`         password# Z 5a      ��5]   1   Z� .��5a   P    5b      ��%�   '        �� 5c      "  6   .�5d      ��  � ��$ Center=�6<   �� 5e       � ��
 �����63   �� 5f       �@J�Opacity$ 1Q�60   5g      5h      .��6!   ��5i      �� 5j      $' !MaterialDesignFloatingHintTextBox��6!   .��5k      5l      �� 5n   
   -   5        $��textBoxReEnterPassword��5n      $��2q�60   $
��Left=�6D   $��55��5o      $��538,299,0,0q�6   $
 Wrap=�6.   $	��Top=�5p      $	��182��6%   
�������$��10, 8, 10, 0q�5q   !    . $ 5��5s         reEnterPassword# Z 5t      ��5p   1   Z� .��5t   W    5u      ��%�   '        �� 5v      "  6   .�5w      ��  � ��$ Center=�6<   �� 5x       � ��
 �����63   �� 5y       �@J�Opacity$ 1Q�60   5z      5{      .��6!   ��5|      �� 5}      $' !MaterialDesignFloatingHintTextBox��6!   .��5~      5      �� 5�   
   -   5        $��textBoxNickname��5�      $��2q�6)   $
��Left=�6=   $��55��5�      $��538,399,0,0q�6   $
 Wrap=�6.   $	��Top=�5�      $	��182��6%   
�������$��10, 8, 10, 0q�5�   !    . $ 5��5�         nickName# Z 5�      ��5�   1   Z� .��5�   P    5�      ��%�   '        �� 5�      "  6   .�5�      ��  � ��$ Center=�6<   �� 5�       � ��
 �����63   �� 5�       �@J�Opacity$ 1Q�60   5�      5�      .��6!   ��5�      �� 5�      $' !MaterialDesignFloatingHintTextBox��6!   .��5�      5�      �� 5�   
   $��/Images/FootPrint.png��6   $
��Left=�6/   $	��190��6J   $	��Top=�5�      $	��214��6(   $��848,33,-70,0q�64   '  !MaterialDesignThemes.Wpf.PackIcon  5�   
      Kind$ Account=�6"   $��37��61   $��40��6=   $��227,199,0,0q�6H     5�   
   $ Account=�6"   $��37��61   $��40��6=   $��227,299,0,0q�6H     5�   
   $ Email=�6"   $��37��6/   $��40��6;   $��227,399,0,0q�6F     5�   
   $
 Lock=�6"   $��37��6.   $��40��6:   $��733,199,0,0q�6E     5�   
   $ 	LockReset=�6"   $��37��63   $��40��6?   $��733,299,0,0q�6J     5�   
   $	 Cat=�6"   $��37��6-   $��40��69   $��733,399,0,0q�6D   �� 5�   
   .+�5�      �� -   5         # MaterialDesignRaisedLightButton#��[ 5�      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 5��6N   $	��203��5�       �� Left$	 395��6   
 �� Top$	 581��6/   $��58��6@   
������ 
���   �{�5�      �� *DataContext.ControlsEnabled+ �� RelativeSource �� *FindAncestor+ �� AncestorType$ WindowL�.��5�      ��     createAccountButton#��Z  6   ��5�      �� 5�      $ 0,0.5&�6*   $ 1,0.5&�6=   .��5�      � $ #FFDE59��6'   $ -0.50Q�67   � 5�      $ #FF66C4��6'   $ 1Q�67   5�      5�      5�        5�   
   -   5        $ ArrowULeftBottomBold=�5�   "   $��44��6>   $��54��6J   $��	10,10,0,0q�5�   "   ! � Cursor$
! Hand��5�   "   �� 5�   
   -	   5        " ��Name$" stackPanelBlack��5�      
���   �# J� Opacity$	# 0.5Q�6A   $y�	Collapsed=�6O   5�      5�      