   M S B A M L   `   `   `  ����G  CmacrixTestTL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:macrixTestTLmacrixTestTL  5   	       macrixTestTL.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:macrixTestTL     5   	     � Title$  Users��5   	   $
��auto��6   $
��auto��6%    � WindowState$ 	Maximized=�5	   	    � 
ResizeMode$ NoResize=�5
   	   .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��4* �6   �� 5      $��1* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGrid��5      $��6��6%   $
��10,0q�69      CanUserAddRows .    ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6]      AutoGenerateColumns .  ��6n   �� *xList+	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 
First name��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *	firstName+ �� UpdateSourceTrigger$ 	LostFocus=�  5      $
 	Last name��6%    68   �� *
lastName+$ 	LostFocus=�  5      $
 Street name��6%    6:   �� *
streetName+$ 	LostFocus=�  5      $
 House number��6%    6;   �� *houseNumber+$ 	LostFocus=�  5       $
 Apartment number��6%    6?   �� *apartmentNumber+$ 	LostFocus=�  5!      $
 Postal code��6%    6:   �� *
postalCode+$ 	LostFocus=�  5"      $
 Phone number��6%    6;   �� *phoneNumber+$ 	LostFocus=�  5#      $

 Town��6%    63   �� *town+$ 	LostFocus=�  5$      $
 
Birth date��6%    69   �� *	birthDate+ �� StringFormat$ {0:yyyy-MM-dd}�� �� NotifyOnTargetUpdated . $ 	LostFocus=�  5%      $	
 Age��6%      
IsReadOnly .  62   �� *age+ . $ 	LostFocus=�6�   5(      �� 5)   
   -   5         ��Name$ bSave��5)      $
��Save��6    $��1��6/   $��10,40q�6?   $��1��6N   6[   �� 5*   
   -   5        $ bCancel��5*      $��Cancel��6"   $��4��63   $��10,40q�6C   $��1��6R   6_   5-      5.      