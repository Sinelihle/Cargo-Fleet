   M S B A M L   `   `   `  ����V  RCargo-Fleet-Tracking-System, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Cargo_Fleet_Tracking_SystemCargo_Fleet_Tracking_System  5   	   .    (Cargo_Fleet_Tracking_System.CallServices   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:Cargo_Fleet_Tracking_System     5   	     � Title$  CallServices��5   	   $	��450��6   $	��769��6+    � SizeToContent$ Manual=�67   .��5	      � ���	#FFD6D6D6$��0,0,0,0q�6"   .+�5
   
   �� $��Vehicle Number��6   $
��Left=�6)   $��	30,83,0,0q�6D   $	��Top=�6W   �� 5   
   $��Service Type��6   $
��Left=�6'   $��
30,130,0,0q�6B   $	��Top=�6V   �� 5   
   $��Appointment Date��6   $
��Left=�6+   $��
30,174,0,0q�6F   $	��Top=�6Z   �� 5   
   $��Work To be completed��6   $
��Left=�6/   $��
30,215,0,0q�6J   $	��Top=�6^   �� 5   
   -   5         ��Name$ txtVehicleNo��5      $
��Left=�6(   $��
173,79,0,0q�6C    �� TextWrapping$
 Wrap=�6W   $�� ��6k   $	��Top=�6s   $��30��6�   $	��100��6�   
�������
����iA�6�   �� 5   
   -   5        $ txtServiceType��5      $
��Left=�6*   $��173,130,0,0q�6E   $
 Wrap=�6Z   $�� ��6n   $	��Top=�6v   $��30��6�   $	��100��6�   
�������
����iA�6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ dateAppoint��5      $
��Left=�6*   $��173,174,0,0q�6E   $	��Top=�6Z   $��30��6r   $	��100��6~   �� 5   
   -   5        $ txtCompleted��5      $
��Left=�6(   $��173,215,0,0q�6C   $
 Wrap=�6X   $�� ��6l   $	��Top=�6t   $��30��6�   $	��100��6�   
�������
����iA�6�   �� 5   
   $��Call Service��6   $��17(�6'   $��Black"�65   $
��Left=�6H   $��	30,30,0,0q�6c   $	��Top=�6v   $	��193��6�   $��28��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ gridData��5      $��30,270,143,59q�6P   �� 5   
   -   5         ��Name$ okBtn��5      $��OK��6    $
��Left=�6-   $��
40,380,0,0q�6H   $	��Top=�6\   $��30��6t   $��74��6�   6�   �� 5   
   -   5        $ backBtn��5      $
��Back��6"   $
��Left=�61   $��146,380,0,0q�6L   $	��Top=�6a   $��77��6y   $��30��6�   6�   5      5      