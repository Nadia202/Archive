   M S B A M L   `   `   `  ����B  >Archive, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PPPP  5   	       Archive.ImageWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   %mchttp://schemas.openxml     5   	   "localclr-namespace:PP     5   	   _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$)  #Страницы документа��5   	   $	��700��6$   $	��500��61   $	��700��6=   $	��500��6M    � Icon$ Resources\Архив.ico��5	   	   .��5
      � 
������� � ColumnDefinitions 5   
   �� 5      $
��0.1* �6   �� 5      $��1* �6   �� 5      $
��0.1* �6    � RowDefinitions 5   
   �� 5      $
��0.1* �6   �� 5      $��1* �6   �� 5      $
��0.1* �6   .+�5   
   (�  (� Stretch$ Uniform=�6   $��1��6$   $��1��64   .��5      �� -   5         ��Name$ 
ImagePhoto��5      ��6(   �� *photo+5      �� 5   
   $��1��6   $��2��6%    �� Orientation$ 
Horizontal=�62   $��Center=�6K   .+�5      �� -   5         ��Name$ btnBack��5      $��10q�5      $��30��5      $��30��5      $��0q�5      .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ ChevronLeft=�6*   $��30��5    *   $��30��5!   *   5"      �� 5#      -   5        	 ��Name$	 
infTextBox��5#      $��Center=�6,   $��18(�6G   $��Black"�6U   �� 5$      -   5        $ btnNext��5$      $��10q�5%      $��30��5&      $��30��5'      $��0q�5(      .��5*        $ ChevronRight=�6*   $��30��5+   *   $��30��5,   *   5-      5.      �� 5/   
   -   5        $ btnDoc��5/      $��Открыть PDF��50      $��2��51      $��1��52      $��	260 0 0 0q�53      $	��120��54      $��30��55      $��0q�56      57   (   58      59      