   M S B A M L   `   `   `  ����H  DVirtualDevice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:VirtualDeviceVirtualDevice  5   	       VirtualDevice.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:VirtualDevice     5   	     � Title$  Virtual Device��5   	   $��386.6��6    $	��585��6/   .��5	      � $��0,0,0.4,-0.2q�6    � ColumnDefinitions 5
   
   �� 5      $
��169* �6   �� 5      $
��145* �6   .+�5   
   �� -   5         ��Name$ unitOfMeasurementLabel��5      $��Unit of Measurement:��60   $
��Left=�6O   $��
36,130,0,0q�6j   $	��Top=�6~   $��26��6�   $	��124��6�   �� 5   
   -   5         ��Name$ unitOfMeasurementComboBox��5      $
��Left=�66   $��181,130,0,0q�6Q   $	��Top=�6f   $	��120��6~    �� SelectedIndex$ 0��6�   $��26��6�   .@�5      �� $��Inches��6   $
��Left=�6,   $��118.4��6G   �� 5      $��Centimeters��6   $
��Left=�61   $��118.4��6L   5      �� 5   
   -   5        $ statusLabel��5      $��Status: Ready��6%   $
��Left=�6=   $��55.8,128,0,0q�6X   $	��Top=�6n   $	��160��6�   $��1��6�   $��43��6�   �� 5   
   -   5         ��Name$ startStopButton��5      $��Start Collecting Data��6*   $
��Left=�6J   $��	20,10,0,0q�6e   $	��Top=�6x   $	��530��6�   $��98��6�   $��2��6�   �� 5   
   -   5        $$ getMostRecentMeasurementButton��5      $%��Display Most Recent Measurement��69   $
��Left=�6c   $��
16,187,0,0q�6~   $	��Top=�6�   $	��285��6�   $��27��6�   6�   �� 5   
   -   5        $ recentMeasurementLabel��5      $#��Most Recent Measurement: None��60   $
��Left=�6X   $��
16,225,0,0q�6s   $	��Top=�6�   $	��285��6�   $	��104��6�   �� 5   
   -   5        $ getRawDataButton��5      $)��#Display Raw Data (Newest to Oldest)��6+   $
��Left=�6Y   $��23.8,187,0,0q�6t   $	��Top=�6�   $	��215��6�   $��27��6�   $��1��6�   �� 5   
   -   5         ��Name$ rawDataListBox��5      $
��Left=�6*   $	��104��6E   $��23.8,225,0,0q�6R   $	��Top=�6h   $	��215��6�    J� RenderTransformOrigin$ 	0.514,0.5&�6�   $��1��6�   5      5      