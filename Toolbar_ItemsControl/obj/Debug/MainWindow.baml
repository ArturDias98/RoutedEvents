   M S B A M L   `   `   `  ����O  KToolbar_ItemsControl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Toolbar_ItemsControlToolbar_ItemsControl  5   	   M+clr-namespace:Toolbar_ItemsControl.ControlsToolbar_ItemsControl.Controls  5   	   %    Toolbar_ItemsControl.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:Toolbar_ItemsControl     5   	   ?toolbar+clr-namespace:Toolbar_ItemsControl.Controls     5   	   -   5          �Name$
  Main��5	   	   $	��500��5
   	   $	��300��5   	    � Title$ 
MainWindow��5   	   .��5      �  � ColumnDefinitions 5   
   �� 5      $��5 �6   �� 5      $��* �6   �� 5      $��5 �6    � RowDefinitions 5   
   �� 5      $��5 �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��5 �6   .+�5   
   ]� $��1��5      $��Center=�5      $��Center=�5      $��1��5      .+�5      �� $��10q�5!      
�������$��45(�5#      ��5      �� *	LeftValue+ �� ElementName$
 Main��y�5       �� *LeftVisibility+$
 Main��    BooleanToVisibilityConverter �� 	Converter# [  5#      �� 5%      $��10q�5&      
�������$��45(�5(      ��5)      �� *
RigthValue+$
 Main��y�5*      �� *RigthVisibility+$
 Main��# [  5,      2   ,Toolbar_ItemsControl.Controls.ToolBarControl  5-   
   2   ,Toolbar_ItemsControl.Controls.ToolBarControl   UpClick$ ToolBarControl_UpClick��50         	DownClick$ ToolBarControl_DownClick��51         VisibilityChange$% ToolBarControl_VisibilityChange��52      $��1��5.      $��2��5/      $��Center=�53      $��Center=�54      	   NumItems$	 2��55      56      57      