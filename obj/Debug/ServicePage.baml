   M S B A M L   `   `   `  ����V  RCargo-Fleet-Tracking-System, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Cargo_Fleet_Tracking_SystemCargo_Fleet_Tracking_System  5      -    'Cargo_Fleet_Tracking_System.ServicePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:Cargo_Fleet_Tracking_System     5        N� Title$  ServicePage��5      $	��593��6   .��5
      � ���	#FFD6D6D6$��	0,0,154,0q�6"   .+�5   
   �� -   5         ��Name$ dailyBtn��5      $��Daily��6#   $
��Left=�63   $��
30,350,0,0q�6N   $	��Top=�6b   $��23��6z   $��74��6�   6�   �� 5   
   -   5        $ 	weeklyBtn��5      $��Weekly��6$   $
��Left=�65   $��132,350,0,0q�6P   $	��Top=�6e   $��23��6}   $��76��6�   6�   �� 5   
   $��Vehicle Number��6   $
��Left=�6)   $��	30,83,0,0q�6D   $	��Top=�6W   �� 5   
   $��Services to be performed��6   $
��Left=�63   $��
30,183,0,0q�6N   $	��Top=�6b   $	��148��6z   �� 5   
   $��Procedure Code��6   $
��Left=�6)   $��
30,233,0,0q�6D   $	��Top=�6X   $	��140��6p   �� 5   
   $��Description��6   $
��Left=�6&   $��
30,268,0,0q�6A   $	��Top=�6U   $	��148��6m   �� 5   
   $��Appointment Date��6   $
��Left=�6+   $��
30,132,0,0q�6F   $	��Top=�6Z   �� 5   
   $��Schedule Service��6   $��15(�6+   $��DemiBold"�69   $��Center=�6O   $
��Left=�6q   $��
229,32,0,0q�6�   $	��Top=�6�   $��38��6�   $	��124��6�   �� 5   
   -   5         ��Name$ txtVehicleNo��5      $
��Left=�6(   $��
170,87,0,0q�6C    �� TextWrapping$
 Wrap=�6W   $�� ��6k   $	��Top=�6s   $��30��6�   $	��100��6�   
�������
����iA�6�   �� 5   
   -   5        $ 
txtService��5      $
��Left=�6&   $��170,183,0,0q�6A   $
 Wrap=�6V   $�� ��6j   $	��Top=�6r   $��30��6�   $	��100��6�   
�������
����iA�6�   �� 5   
   -   5        $ txtCode��5      $
��Left=�6#   $��170,233,0,0q�6>   $
 Wrap=�6S   $�� ��6g   $	��Top=�6o   $��30��6�   $	��100��6�   
�������
����iA�6�   �� 5   
   -   5        $ txtDescription��5      $
��Left=�6*   $��170,281,0,0q�6E   $
 Wrap=�6Z   $�� ��6n   $	��Top=�6v   $��30��6�   $	��100��6�   
�������
����iA�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
weeklyGrid��5      $��291,121,10,299q�6R   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ appointDate��5      $
��Left=�6*   $��170,134,0,0q�6E   $	��Top=�6Z   �� 5   
   $��Daily Service��6   $
��Bold"�6(   $
��Left=�6:   $��291,336,0,0q�6U   $	��Top=�6j   $	��182��6�   �� 5   
   $��Weekly Services��6   $
��Bold"�6*   $
��Left=�6<   $��
291,84,0,0q�6W   $	��Top=�6k   $	��182��6�     5   
   -	   5        $ 	dailyGrid��5      $��291,357,10,123q�6Q   �� 5   
   -
   5        $��CALL service job ?��5      
������ 
������ 
����  �$
��Left=�6s   $��
84,446,0,0q�6�   $	��Top=�6�   6�   �� 5   
   -   5        $ btnUpdateDaily��5      $��Update Daily by ID��6)   $
��Left=�6F   $��
26,509,0,0q�6a   $	��Top=�6u   $��35��6�   $	��103��6�   6�   �� 5   
   $��UserID��6   $
��Left=�6!   $��
26,469,0,0q�6<   $	��Top=�6P   �� 5   
   -   5        $ 	txtUserID��5      $
��Left=�6%   $��
78,473,0,0q�6@   
����iA�$
 Wrap=�6l   $�� ��6�   $	��Top=�6�   $	��120��6�   �� 5    
   -   5        $ btnUpdateWeekly��5       $��Update Weekly by ID��6*   $
��Left=�6H   $��168,509,0,0q�6c   $	��Top=�6x   $��35��6�   $	��123��6�   6�   �� 5!   
   -   5        $ 
refreshBtn��5!      $��Refresh��6%   $
��Left=�67   $��323,509,0,0q�6R   $	��Top=�6g   $��35��6   $��84��6�   6�   5#      5$      