   M S B A M L   `   `   `  ����G  CRegisterPage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:RegisterPage.Properties.LangsRegisterPage.Properties.Langs  5   	   #    RegisterPage.MessageBoxCustom   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @language+clr-namespace:RegisterPage.Properties.Langs     5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  MessageBoxWindow��5   	   $	��321��6"   $	��561��6/    � WindowStartupLocation$ CenterScreen=�5	   	    � WindowStyle$
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
StartPoint$ 0,0.5&�6*    �� EndPoint$ 1,0.5&�6=   .��5(      �  � Color$ #FF83C6��6'    � Offset$	 0.0Q�67   � 5)      $ #8C6CFF��6'   $ 1Q�67   5*      5,      �� 5.      $��Right=�6   $��0,5,5,0q�66   $	��Top=�6H   $��1��6`   .+�5/      �� -   5         ��Name$ buttonClose��5/      $��35��6H   $��35��6S   
�������  PrimaryHueDarkBrush#���  6s    * &MaterialDesignFloatingActionDarkButton#��[ 6�   .��50      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�6.   51      52      �� 54      -   5         ��Name$ txtTitle��54       �� TextAlignment$ center=�6*   $��Center=�6A   $��Stretch=�55      $��35(�64   ���#545454$%��Gill Sans MT Ext Condensed Bold)�57      $	��120��6E   $��220,14,221,262q�6Q   Message Title6x   �� 59      -   5         ��Name$ imageMichyOk��59      $��/Images/MichyOk.png��6*   $
��Left=�6G   $	��109��6b   $	��Top=�5:      $	��143��6)   $��-27,157,0,0q�65   $y�	Collapsed=�6J   �� 5;      -   5        $ imageInvalidMichy��5;      $��/Images/InvalidMichy.png��6/   $
��Left=�6Q   $	��109��6l   $	��Top=�5<      $	��152��6)   $��-27,163,0,0q�65   $y�	Collapsed=�6J   �� 5=      -   5        $ imageWaitMichy��5=      $��/Images/WaitMichy.png��6,   $
��Left=�6K   $	��104��6f   $	��Top=�5>      $	��143��6)   $��-25,160,0,0q�65   $y�	Collapsed=�6J   � 5A      $��20,45,20,10q�6   
 5D      �� 5E      $
��auto �6$   �� 5F      $
��auto �6$   �� 5G      $��* �6$   .+�5J      � $��0��6   
 5K      �� 5L      $
��auto �6(   �� 5M      $��* �6(   .+�5P      �� 
������ 6   ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  5R      $��0,20,0,0q�6:   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffects 5S      ;  5MaterialDesignThemes.Wpf.Transitions.TransitionEffect  5T         Kind$ FadeIn=�6>     5U      $ SlideInFromBottom=�6>   .��5W      �� -   5         ��Name$ textBoxMessage��5W   "   $��Center=�6:    �� 
IsReadOnly . $��0��5X   "   $��5q�6/   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$  ��6:   $��27(�6\    % !MaterialDesignFloatingHintTextBox#��[ 5Y   "    �� TextWrapping$
 Wrap=�6]   ���#545454$ ��Gill Sans MT Ext Condensed)�5Z   7   5[      �� 5]      -   5        $ textBoxConfirmationCode��5]      $��Center=�6?   $��175,29,175,-85q�6\   $��1��5^   "   $��15(�6/   $��10, 8, 10, 0q�6=   $	��171��6T   #��[ 5_   "   $y�	Collapsed=�6]   $ ��Gill Sans MT Ext Condensed)�5`   "   ���#545454.  (MaterialDesignThemes.Wpf.TextFieldAssist   HasClearButton . (   "RegisterPage.Properties.Langs.Lang   yourCodeHere# Z 5b   "   .��6i    � 	Resources 5c      (	  "MaterialDesignThemes.Wpf.SmartHint �� 
TargetType �� Property  �� Value��%y   '	        �� 5d      " 	 6$   .�5e   "   ��  � ��$  Center=�6H   �� 5f   "    � ��$  2(�6=   5g      5h      .��6-   5i      5k      � 5m      $��1��6   $��	0,108,0,0q�6$   $��2��67   	 5n      �� 5o      $��* �6+   �� 5p      $
��auto �6+   �� 5q      $
��auto �6+   �� 5r      $��* �6+   .+�5u      �� 
������ 6   �� 5w      -   5        $ buttonOk��5w      $��1��6F    # MaterialDesignRaisedLightButton#��[ 5x   !   $��5q�5y   !   $	��100��6,   ! � ToolTip$! Ok��68   
������ .��5z      �� $��Ok��6$   ��5{      �� 5|      $ 0,0.5&�62   $ 1,0.5&�6E   .��5}   "   � $ #FFDE59��6/   $ -0.50Q�6?   � 5~   "   $ #FF66C4��6/   $ 1Q�6?   5      5�      �� 5�      -	   5        $ buttonSubmit��5�      $��1��6N   #��[ 5�   !   $��5q�5�   !   $	��100��6,   $! Submit��68   
������ .��5�      �� $��Submit��6$   ��5�      �� 5�      $ 0,0.5&�62   $ 1,0.5&�6E   .��5�   "   � $ #FFDE59��6/   $ -0.50Q�6?   � 5�   "   $ #FF66C4��6/   $ 1Q�6?   5�      5�      �� 5�      -
   5        $ buttonAccept��5�      $��1��6N   #��[ 5�   !   $��5q�5�   !   $	��100��6,   $! Accept��68   
������ .��5�      �� $��Accept��6$   ��5�      �� 5�      $ 0,0.5&�62   $ 1,0.5&�6E   .��5�   "   � $ #FFDE59��6/   $ -0.50Q�6?   � 5�   "   $ #FF66C4��6/   $ 1Q�6?   5�      5�      �� 5�      -   5        $ buttonCancel��5�      $��2��6N   #��[ 5�   !   $��5q�5�   !   $	��100��6,   $! Cancel��68   
������ .��5�      �� $��Cancel��6$   ��5�      �� 5�      $ 0,0.5&�62   $ 1,0.5&�6E   .��5�   "   � $ #FFDE59��6/   $ -0.50Q�6?   � 5�   "   $ #FF66C4��6/   $ 1Q�6?   5�      5�      5�      5�      5�      5�      5�      