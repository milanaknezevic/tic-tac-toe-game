   M S B A M L   `   `   `  ����G  CIks-oks_game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Iks_oks_gameIks_oks_game  5   	       Iks_oks_game.ScoreWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
   &localclr-namespace:Iks_oks_game  5   	     � Title$  GameRezim1Window��5	      $	��300��6!   $	��550��6.    � WindowStartupLocation$ CenterScreen=�6:    � WindowStyle$
 None=�6_    � 
ResizeMode$ NoResize=�6r   .��5
      � ��5   
   �� 5       �� ImageSource$) #/istockphoto-1289153517-170667a.jpg��6   .+�5   
   �� -   5         ��Name$ btnExit��5   #   $��484,10,10,233q�5       &  "MaterialDesignFloatingActionButton#��[  6)   ���	#FFFF4A00 � ToolTip$ Close��5      $��57��6J   .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�6&   
�������
���   �$��30��6b   $��30��6m   5      �� 5   
   -   5         ��Name$ BrojIgranjaLabel��5      $��Broj igranja:��6*   
�������$��Arial Black)�6Y   ���	#FFFF4A00$��16(�6�   $��18,20,371,233q�6�   �� 5   
   -   5        $ igrac1Label��5      $��Igrač 1 (X):��6%   
�������$��Arial Black)�6S   ���	#FFFF4A00$��16(�6�   $��18,105,408,150q�6�   �� 5   
   -   5        $ igrac2Label��5      $��Igrac 2 (O):��6%   $��196,105,230,150q�6<   
�������$��Arial Black)�6l   ���	#FFFF4A00$	��124��6�   $��16(�6�   �� 5   
   -   5        	 ��Name$	 Igrac1TextBox��5      $
��Left=�6)   $��
18,180,0,0q�6D   
 �� TextWrapping$

 Wrap=�6X   $��Arial Black)�6l   ���	#FFFF4A00$��16(�6�    �� 
IsReadOnly$
 True��6�   $	��Top=�6�   $	��124��6�   �� 5   
   -   5        $	 Igrac2TextBox��5      $
��Left=�6)   $��196,180,0,0q�6D   $

 Wrap=�6Y   $��Arial Black)�6m   ���	#FFFF4A00$��16(�6�   $
 True��6�   $	��Top=�6�   $	��124��6�    J� RenderTransformOrigin$ 0.255,0.521&�6�   5      5      