   M S B A M L   `   `   `  ����G  CRegisterPage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:RegisterPageRegisterPage  5   	   M+clr-namespace:RegisterPage.Properties.LangsRegisterPage.Properties.Langs  5   	       RegisterPage.LogIn   5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5
   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:RegisterPage     5   	   @language+clr-namespace:RegisterPage.Properties.Langs     5   	      MaterialDesignBody#���   5   
   $��Regular"�5   
   $��13(�5   
   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   
      TextRenderingMode$
 Auto=�5   
     MaterialDesignPaper#���  5   
     MaterialDesignFont#���  5	   
    � Title$ LogIn��5   	   $	��700��6   $
��1000��6$    � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode$ NoResize=�6.   .��5      � ��5   
   �� 5       �� 
StartPoint$ 0,0.5&�6"    �� EndPoint$ 1,0.5&�65   .��5      �  � Color$ #FF83C6��6    � Offset$	 0.0Q�6/   � 5      $ #8C6CFF��6   $ 1Q�6/   5      .+�5   
   �� $��Center=�6   $	��Top=�64   $	��104��6L   $%��Gill Sans MT Ext Condensed Bold)�5      $	��100(�6=   ���	#FF545454$��RUMMICHY��5   =   $��339,48,319,0q�6P   ��6   Z� 6P   G� 5   
   -   5        $��passwordBoxLogInPassword��5      (   "RegisterPage.Properties.Langs.Lang	   password)  #MaterialDesignThemes.Wpf.HintAssist
   Hint#
 Z	 66      
Foreground
 �����$��356,346,337,265q�5   B    % !MaterialDesignOutlinedPasswordBox#��[ 5       
�������   
Background
 ����    FloatingScale$ 1Q�5"      $	��1.5q�6A      FloatingOffset$ 0, -35&�5#      
�������5$      �� 5&   
   -   5        $��textBoxLogInNickName��5&   I    ! MaterialDesignOutlinedTextBox#��[ 6    �� AcceptsReturn .    nickName#
 Z 5'      $��356,252,337,360q�6T   
�������
 ���� 
 �����$ 1Q�5*      $	��1.5q�6=   $ 0, -35&�5+      
�������5,      �� 5/   
   $��/Images/Michy.png��6   $
��Left=�6+   $	��208��6F   $	��Top=�50      $	��366��6)   $��
-32,36,0,0q�65   �� 52   
   $(��"/Images/RegisterLinkBackground.png��6   $
��Left=�6<   $	��207��6W   $	��Top=�53      $	��367��6)   $��356,559,0,-97q�65   �� 55   
    $  MaterialDesignSubtitle2TextBlock#��[ 6   $��15(�6N   ���	#FF545454   accountQuestion#��Z 56   >   $��376,628,475,11q�6n   ��6   Z� 6n   �� 58   
   -   5        #��[ 58      $��15(�6N   ���#FFE975   registerLink#��Z 5:      $��518,628,392,11q�5;       � Cursor$
 Hand��6)   ��59      Z� 5;   7   '  !MaterialDesignThemes.Wpf.PackIcon  5=   
      Kind$ 	Translate=�6"   $��26��63   $��29��6?   $��
767,31,0,0q�5>   "   ���	#FF54545466   �� 5@   
   -   5        $��comboBoxLanguage��5A         selectLanguage#
 Z 5@      $��5q�5B       �� Left$ 59��6   
 �� Top$	 208��6.   $��801,31,20,596q�6?    �	#FF545454���	#FF545454.@�5D      �� 	   en#��Z 6   �� 5E         es_MX#��Z 6   5G      �� 5I   
   .+�5J      �� -   5         # MaterialDesignRaisedLightButton#��[ 5J      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 5��6N   $	��302��5K      $	 355��6   $	 440��6/   $��39��6@   
������ 
���   �.��5M      ��    logIn#��Z 6   ��5N      �� 5O      $ 0,0.5&�6*   $ 1,0.5&�6=   .��5P      � $ #FFDE59��6'   $ -0.50Q�67   � 5Q      $ #FF66C4��6'   $ 1Q�67   5R      5T      5U      �� 5W   
   -   5         ��Name$ stackPanelBlack��5W      
���   � J� Opacity$	 0.5Q�6A   $y�	Collapsed=�6O   5Y      5Z      