   M S B A M L   `   `   `  ����E  APizzza app, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Pizzza_app
Pizzza_app  5   	       Pizzza_app.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Pizzza_app     5   	     � Title$  
MainWindow��5   	   $	��500��6   $	��900��6)   .��5	      � $��0,0,0,-6q�6   .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
MenuSelect��5
      $��23,71,520,33q�6A      AutoGenerateColumns . 6�   �� 5   
   -   5         ��Name$ 	Selection��5      $��23,15,728,447q�6&    �� SelectedIndex$ 0��6j   �� 5   
   -   5         ��Name$ Buy_check_out��5      $
��køb��6(   $
��Left=�66   $��439,370,0,0q�6Q   $	��Top=�6f   $��50��6~   $��50��6�   6�   �� 5   
   -   5        $ Fjern_Remove��5      $��Fjern��6'   $
��Left=�67   $��439,230,0,0q�6R   $	��Top=�6g   $��50��6�   $��50��6�   �� 5   
   -   5        $	 ADD��5      $	��ADD��6   $
��Left=�6,   $��439,300,0,0q�6G   $	��Top=�6\   $��50��6t   $��50��6�   6�   �� 5   
   $��Checkout list��6   $
��Left=�6(   $��
656,17,0,0q�6C   $	��Top=�6W     5   
   -   5        $ CartItemsGrid��5       .  $��539,66,48,33q�6�   ��6F   ��  �� ElementName$ 	CartItems�� �� Path$ Items�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Number��6%   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 65   �� *MenuItem.Number+  5      $
	 Name��6%   
 63   �� *MenuItem.Name+  5      $	 Price��6%   
 64   �� *MenuItem.Price+5      5      5      