   M S B A M L   `   `   `  ����B  >Archive, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PPPP  5      !    Archive.PageAddOrganization   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      "localclr-namespace:PP     5      _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� FontSize$  16(�5	       N� Title$ PageAddOrganization��5      .��5      � 
�������.+�5   
   �  � ColumnDefinitions 5      �� 5      �� 5      $
��auto �6#   �� 5       � RowDefinitions 5      �� 5      $��50��6    �� 5      $
��auto �6    �� 5      $��50��6    .+�5      �� $��1��5      $��1��5      $��Center=�5      $��Center=�5      $	��400��5      $	��500��5      
������ �� CornerRadius$ 15��5!       �� Padding$ 20q�5"       J� Effect 5#      3  -System.Windows.Media.Effects.DropShadowEffect  5$         
BlurRadius$ 30Q�6#      ShadowDepth$ 10Q�63   	   Color$	 Green��6D   6T   ._�5&      �� .+�5'      �� -   5        
 ��Name$
 
innTextBox��5'      $
��10 5q�5)      $��Black"�5*      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ ИНН��5,       �� 	MaxLength$ 10��5-      /  )MaterialDesignThemes.Wpf.TransitionAssist   DisableTransitions .  %  !MaterialDesignFloatingHintTextBox#��[  5/      ��5(      �� *id+5/      �� 51      -   5        $
 directorTextBox��51      $
��10 5q�53      $��Black"�54      $ Директор��55      #��[  56       � Cursor$ Arrow��6U   ��52      �� *
director+56   U   �� 58      -   5         ��Name$ opfComboBox��58       �� DisplayMemberPath$
 type��5:      $
��10 5q�5;      $��Black"�5<      $ ОПФ��5=       & "MaterialDesignFloatingHintComboBox#��[ 5>       �� SelectedItem 59      �� *	TypeOPF+5>      �� 5@      -   5        $
 nameTextBox��5@      $
��10 5q�5B      $��Black"�5C      $ Название��5D      #��[  5E      ��5A      �� *name+5E      �� 5G      -   5        $
 
kppTextBox��5G      $
��10 5q�5I      $��Black"�5J      $ 9��5L       . $ КПП��5N      #��[  5O      ��5H      �� *kpp+5O      �� 5Q      -   5        $
 ogrnTextBox��5Q      $
��10 5q�5S      $��Black"�5T      $ 13��5V       . $ ОГРН��5X      #��[  5Y      ��5R      �� *ogrn+5Y      �� 5[      -   5        $
 addressTextBox��5[      $
��10 5q�5]      $��Black"�5^      $ 
Адрес��5_      #��[  5`      ��5\      �� *	address+5`      �� 5b      -   5         ��Name$ btnSave��5b      $��60 20q�5c      $��Сохранить��5d      5e      5f      5g      �� 5h      -	   5        $ btnExit��5h      $��2��5i      $��2��5j       . *MaterialDesignFloatingActionMiniDarkButton#��[ 5k      $
��Left=�5l      $	��Top=�5m      $��0q�5n      $��40��5o      $��40��5p      .��5r      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ ArrowLeftCircleOutline=�6*   $��40��5s   &   $��40��5t   &   5u      5v      5w      5x      