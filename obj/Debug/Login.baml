   M S B A M L   `   `   `  ����V  RCargo-Fleet-Tracking-System, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Cargo_Fleet_Tracking_SystemCargo_Fleet_Tracking_System  5   	   '    !Cargo_Fleet_Tracking_System.Login   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:Cargo_Fleet_Tracking_System     5   	     � Title$  Login��5   	   $	��396��6   $��795.5��6$    � 
ResizeMode$ CanMinimize=�62    � 	Resources 5
         FocusVisual �� Property �� Value J� SnapsToDevicePixels �� StrokeDashArray  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 RoundedBorderStyle �� 
TargetType	 �� 
TargetType
 ��Name �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName��%�  &	        &	 �     &	 �     &	 �     &	     &	 6    &	 Y    &	 |    &	 �    &		 �    &	
 �    7   7  7  7  7  7 	 �� 5   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$    . #��� ��6J   $��1��6�   $	 1 2R�6�   5      5      5      �� 5   
   $ 	#FFDDDDDD��6;   �� 5   
   $ 	#FF707070��67   �� 5   
   $ 	#FFBEE6FD��6>   �� 5   
   $ 	#FF3C7FB1��6:   �� 5   
   $ 	#FFC4E5F6��6<   �� 5   
   $ 	#FF2C628B��68   �� 5   
   $ 	#FFF4F4F4��6=   �� 5   
   $ 	#FFADB2B5��69   �� 5   
   $ 	#FF838383��6=   �� 5   
   " ��6+   .�5      ��  �@�FocusVisualStyle8   61   �� 5       � ��8  6+   �� 5        � ��8  6,   �� 5!       � ��# � ��6+   �� 5"       � ��$ 0q�60   �� 5#       � ��$ Center=�6;   �� 5$       � ��$ Center=�69   �� 5%       � ��$ 1q�6(   �� 5&       � �� 5'      �� 5(      "	 ��6&   .R�5)      �� $
 border��6!   $ 20��61   #��z��6C   #��z��6o   #��z��6�    . $��	0,0,-25,0q�6�   $��27��6�   ._�5*      �� $ contentPresenter��6/   |�.  #��z��6[   #��z��6�   ��. # z 6�   #��z��6  5+       5,      P� 5-       �@��IsDefaulted . . �5.   "   �� $ border��6@   # � ��6T    � ��5/      P� 50       �@J�IsMouseOver . . �51   "   �� $ border��6?    � �� �#EAB01E6S   �� 52   "   $ border��6@    � �� �#EAB01E6T   53      P� 54       � �� . . �55   "   �� $ border��6?    � �� �#F1CA686S   �� 56   "   $ border��6@    � �� �#F1CA686T   57      P� 58       � {� .  . �59   "   �� $ border��6?   8   � ��6S   �� 5:   "   $ border��6@   8   � ��6T   �� 5;   "   $ contentPresenter��6K   8   � ��6i   5<      5>      5@      5A      5B      .��5C      �  � ColumnDefinitions 5D   
   �� 5E      $
��296* �6   �� 5F      $
��499* �6   .+�5H   
   �� $��Username��6   $
��Left=�6#   $��	58,62,0,0q�6>   $	��Top=�6Q   $��Arial)�6i   $��24��6|   $��82��6�   �� 5I   
   $��Password��6   $
��Left=�6#   $��
58,172,0,0q�6>   $	��Top=�6R   $��Arial)�6j   $��24��6}   $��82��6�   �� 5J   
   -   5         ��Name$ txtUserName��5J      $
��Left=�6'   $��20��6B   $��	58,92,0,0q�6N    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $	��176��6�   G� 5K   
   -   5         G�Name$ pdbPassword��5K      $
��Left=�6+   $��
58,196,0,0q�6F   $	��Top=�6Z   $	��176��6r   $��20��6~   �� 5L   
   -   5         ��Name$ 	btnSignIn��5L      $��Sign In��6$   $
��Left=�66   $��
37,285,0,0q�6Q   $	��Top=�6e   $��74��6}   ���#4682B4
�������$��Arial)�5O      #��� 
 6$   $��26��6Q   6]   �� 5Q   
   -   5        $ btnForgotPd��5Q      $��forgot password��6&   $
��Left=�6@   $��178,285,0,0q�6[   $	��Top=�6p   $��74��6�   ���	#FFC8CACB$��Arial)�5S      #��� 
 6    $��26��6M   $��11(�6Y   $
��Bold"�6g   �� 5U   
   $
��Left=�6   $	��368��6+   $	��Top=�68   $	��499��6P   $��Picture1.jpg��6\   $��	293,0,0,0q�6r   $��2��6�   �� 5V   
   $��	Login As:��6   $
��Left=�6$   $��
41,320,0,0q�6?   $	��Top=�6S   �� 5W   
   -   5         ��Name$ comboUserType��5W      $
��Left=�6*   $��146,324,0,0q�6E   $	��Top=�6Z   $	��120��6r   .@�5X      �� $��Office Manager��6    �� 5Y      $��Vehicle Administrator��6   �� 5Z      $��Trip Manager��6   �� 5[      $��Service Manager��6   �� 5\      $��Timesheet Manager��6   5]      5^      5_      