   M S B A M L   `   `   `  ����B  >Archive, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PPPP  5          Archive.PageSearch   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      "localclr-namespace:PP     5      _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$  
PageSearch��5
      .��5      � 
������� � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   �� -   5         ��Name$ btnExit��5      $��20q�5      $��0q�5      $��30��5      $��30��5      $
��Left=�5      $	��Top=�5      .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	ExitToApp=�6&   $��30��5   &   $��30��5   &   5      �� 5   
   $��20q�6   $��Right=�5      $	��Top=�5       K� ZIndex$ 2��5      .+�5       �� -   5        $ btnUsersList��5       $��0q�5!      $��Right=�5"      $��30��5#      $��30��5$      $y�	Collapsed=�5%      .��5'        $ AccountGroup=�6*   $��25��5(   )   $��25��5)   )   5*      �� 5+      -   5         ��Name$ borederUserList��5+      $	��480��5,      $	��380��5-      
������� �� CornerRadius$ 15��5/       �� Padding$ 10q�50      $y�	Collapsed=�51       J� Effect 52      3  -System.Windows.Media.Effects.DropShadowEffect  53      	   
BlurRadius$	 30Q�6'   
   ShadowDepth$
 10Q�67      Color$ #683ab8��6H   6Z   ._�55      �� .+�56      �� -   5         ��Name$ searchTextBox��56      $
��10 5q�57      $��14(�58      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Поиск��59       %  !MaterialDesignFloatingHintTextBox#��[  5:      6Y   �� 5;      $	��440��6   $	��340��5<      
�������$ 15��5>      ._�5?      �� -   5         ��Name$ listBoxUsers��5?   "   ��5@   "   �� *Users+��5A      �� 5B   "   .R�5C   &   ��  �� Orientation$ Vertical=�61   5D   #   ��5F      �� 5G   "   .R�5H   &   ��  ��Name$ userItem��62   .��5I   *   � $	��245��6/    � ColumnDefinitions 5J   .   �� 5K   2   �� 5L   2   $
��Auto �6C   .+�5N   .   �� $ Vertical=�69   $��0��6P   .+�5O   2   �� $ 
Horizontal=�6=   .+�5P   6   ��  ��Name$ lastNameUser��6@   ��6V   �� *
lastName+�� 5Q   6   $ firstNameUser��6@   $��5 0 0 0q�6r   ��6W   �� *	firstName+6r   �� 5R   6   $ patronymicUser��6@   $��5 0 0 0q�6t   ��6X   �� *
patronymic+6t   5S   3   �� 5T   2   $ psitionUser��6<   ��6Q   �� *PositionUsers.position+5U   /   �� 5V   .   $ 
Horizontal=�69   $
��Left=�6R   $��1��6m   .+�5W   2   �� $ btnChangingPassword��69   -   5        $��20��5X   9   $��20��5Y   9   $��5q�5Z   9   $��0q�5[   9   .��5]   6     $ 
KeyVariant=�5^   9   $��20��5_   9   $��20��5`   9   5a   3   �� 5b   2    ��Name$ adoptedUser��6;   -   5        $��5q�5b   n    d� 	IsChecked 6P   �� *	adopted+6y   5c   /   5d   +   5e   '   5f   #   5h      5i      5j      5k      5l      �� 5m   
   $��Stretch=�6   $��Stretch=�5n      .+�5o      �� $ 
Horizontal=�5p      $��Center=�5q      .+�5r      �� -   5        $ searchOrgTextBox��5r      $��15q�5s      $	��200��5t      $��14(�5u      $��Black"�5v      $ 
Поиск��5w      #��[  5x      /  )MaterialDesignThemes.Wpf.TransitionAssist   DisableTransitions . 5z      �� 5{      -	   5        $ btnAddOrganization��5{      $��30��5|      $��30��5}      $��0q�5~      .��5�        $
 Plus=�6.   $��30��5�   .   $��30��5�   .   5�      �� 5�      -
   5        $ btnUpdateOrganization��5�      $��30��5�      $��30��5�      $��0q�5�      $��10 0 0 0q�5�      {�.  .��5�        $ Pencil=�6.   5�      5�      &   System.Windows.Controls.DataGrid  5�      -   5          Name$ OrganizationDataGrid��5�      
�������   AutoGenerateColumns .     
IsReadOnly .    SelectionMode$ Single=�5�      $��14(�5�       � 	Resources 5�      )  #System.Windows.Controls.DataGridRow �� 
TargetType �� Property �� Value��%k   '        �� 5�      "  6   .�5�      -   5        �� 5�       � ��
 �����67   5�      5�         Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$ ИНН��6)   1	  +System.Windows.Controls.DataGridBoundColumn  	  Binding  66   �� *id+  5�      $ ОПФ��6)     66   �� *TypeOPF.type+  5�      $ Название��6)     6;   �� *name+  5�      $ Директор��6)     6;   �� *
director+  5�      $ 
Адрес��6)     68   �� *	address+5�      5�      5�      5�      