   M S B A M L   `   `   `  ����V  RCargo-Fleet-Tracking-System, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Cargo_Fleet_Tracking_SystemCargo_Fleet_Tracking_System  5      +    %Cargo_Fleet_Tracking_System.TripsPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:Cargo_Fleet_Tracking_System     5        N� Title$  	TripsPage��5	      .��5      � ���	#FFD6D6D6$��	0,0,154,0q�6"   .+�5   
   �� $
��Trip��6   $��Center=�6   $��15(�6C   $��DemiBold"�6Q   $��Center=�6g   $
��Left=�6�   $��
167,28,0,0q�6�   $	��Top=�6�   $��36��6�   $	��170��6�   �� 5   
   $��Destination��6   $
��Left=�6&   $��	33,85,0,0q�6A   $	��Top=�6T   �� 5   
   $��Kilometres Travelled��6   $
��Left=�6/   $��
33,130,0,0q�6J   $	��Top=�6^   �� 5   
   -   5         ��Name$ txtTravelled��5      $
��Left=�6(   
����iA�$��185,143,0,0q�6[    �� TextWrapping$
 Wrap=�6p   $�� ��6�   $	��Top=�6�   $��21��6�   $��89��6�   �� 5   
   -   5        $ txtDestination��5      $
��Left=�6*   
����iA�$��
185,90,0,0q�6]   $
 Wrap=�6q   $�� ��6�   $	��Top=�6�   $��21��6�   $��89��6�   �� 5   
   -   5         ��Name$ btnDaily��5      $��Add To Daily Trip��6#   $
��Left=�6?   $��
33,225,0,0q�6Z   $	��Top=�6n   $��44��6�   $	��116��6�   6�   �� 5   
   -   5        $ 	btnWeekly��5      $��Add To Weekly Trip��6$   $
��Left=�6A   $��185,225,0,0q�6\   $	��Top=�6q   $��44��6�   $	��124��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	gridTrips��5      $��33,291,241,42q�6Q   �� 5   
   -   5        $ 
btnMonthly��5      $��Monthly��6%   $
��Left=�67   $��355,225,0,0q�6R   $	��Top=�6g   $��44��6   $��80��6�   6�   �� 5   
   -   5        $ 	btnDelete��5      $��Delete Records��6$   $
��Left=�6=   $��476,225,0,0q�6X   $	��Top=�6m   $��44��6�   $��88��6�   6�   5      5      