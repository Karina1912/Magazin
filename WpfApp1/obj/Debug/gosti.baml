   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5          WpfApp1.gosti   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:WpfApp1     5        N� Title$  gosti��5	       N� 
Background
 �����.��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      .+�5   
   �  � Orientation$ 
Horizontal=�6   ���	#FF76E383$��Center=�6D   .+�5      �� $��0��6    �� Orientation$ 
Horizontal=�6&   .+�5      �� $6��0Введите название продукта��6   $	��175��6=    �� TextAlignment$ Right=�6I   �� 5      -   5        $��	tbxSearch��5   &   $	��200��6   67   5      �� 5      $ 
Horizontal=�6   .+�5      �� $1��+Выберите производителя��6   $	��175��6:   $ Right=�6F   �� 5      -   5        $��ComboManufacturer��5   '   $	��200��6    �� DisplayMemberPath$ ProductManufacturer��6n   5      5      �� 5   
   -   5         ��Name$ listView��5      $��1��6%   $��Disabled=�62   $��Center=�6h   ��5      �� 5      .R�5      � $ 
Horizontal=�6    $��Center=�69   5      ��5!      �� 5"      .R�5#      �  � ColumnDefinitions 5$      �� 5%      $	��150 �6/   �� 5&      $	��400 �6/   �� 5'      �� 5(      .+�5*      �� $��0��6    $��UniformToFill=�60   $��Center=�6H   $��5q�6e   ��5+      �� 5,   "   	 �� Path$	 ProductPhoto�6*   
 �� TargetNullValue
 5-   &   ��5.   *   picture.png��6C   50   #   52      �� 53      $��1��6%   $��5q�65   $ Vertical=�6@   .+�54      �� $
��Bold"�6E   ��6(   �� *ProductName+6E   �� 55      $
��Bold"�6L   ��6(   �� *ProductDescription+6L   �� 56      $
��Bold"�6M   ��6(   �� *ProductManufacturer+6M   �� 57      $
��Bold"�6`   ��6(   �� *ProductCost+ �� StringFormat$ {0:N2} РУБ��6`   58      �� 59      $��2��6$   $ Center=�6S   $��Center=�6j   ��64   �� *ProductStatus+6j   �� 5:      $��3��6!   $��80��61   $��25��6<   $��5q�6H   ���	#FF498C51$��В корзину��6j   5;      5<      5>      5?      5@      