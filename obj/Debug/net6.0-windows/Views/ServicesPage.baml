   M S B A M L   `   `   `  ????I  EVelvetEyrbrown, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:VelvetEyrbrown.ViewsVelvetEyrbrown.Views  5      '    !VelvetEyrbrown.Views.ServicesPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.6.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .local"clr-namespace:VelvetEyrbrown.Views  5      -   5          N?Name$  servicePage??5
       N? Title$ ServicesPage??6    ? DataContext 5      ??  ?? Mode$ OneWay=? ?? RelativeSource ?? *Self+.??5      ]? .+?5   
   ?? $	??Top=?6   $??35(?6%   $
??Bold"?63   $??Услуги??6E   $??0 0 0 25q?6V   ?? 5   
   $??Услуги??6   ?? 5   
    ?? Orientation$ 
Horizontal=?6      SecondaryHueMidBrush#???   5      $	??Top=?5      .+?5      ?? $??Поиск: ??6   $??18(?6&   $??Center=?64   ?? 5      -   5        $??searchTextBox??5   "   $	??200??6    ! MaterialDesignOutlinedTextBox#???  5      ?? 5      $,??&Сортировать по цене: ??6   $??10 0 0 0q?64   $??Center=?5      ?? 5      -   5         ??Name$ sortingComboBox??5      $	??150??5       " MaterialDesignOutlinedComboBox#???  6#   .@?5      ?? $!??Не сортировать??6   ?? 5      $#??По возрастранию??6   ?? 5      $??По убыванию??6   5      ?? 5      $.??(Фильтрация по скидке: ??6   $??10 0 0 0q?65   $??Center=?5       ?? 5!      -   5        $ filterComboBox??5!   ?   $	??150??5"      #???  6   ??5!      ?? *DiscountFilters+??5#      ?? 5$      .R?5%      ?? ??6    ?? *Key+5&      5(      ?? 5)      -   5        $??20 0 0 0q?5)       % !MaterialDesignOutlinedLightButton#???  6'    ? Cursor$
 Hand??6c   .??5*      ?? $ 
Horizontal=?6   .+?5+      '  !MaterialDesignThemes.Wpf.PackIcon  $??25??6.   $??25??6:      Kind$ DatabaseAdd=?6E   $	??5 0q?6X   ?? 5,        MaterialDesignTextBlock#???  6    Добавить6\   5-      5.      5/      ?? 51   
   $??Bottom=?6   #???   6,   .@?52      ?? Показано ?? 53      ?6   ?? *CurrentCount+ из ?? 6<   ?6@   ?? *
TotalCount+ записей54      55      ?? 56   
   -   5        	 ??Name$	 searchResultLabel??56      $	??Top=?6+   $4??.Введите поисковый запрос??6@   ?? 57   
   ??58      ?? 59      .R?5:      ? $??Disabled=?6!   5;      .@?5=      ?? ??6   ?? *
Services+??5>      ?? 5?      .R?5@      ? $	??800??6   ??6+   ?? *
Discount+  discountToColorConverter
 ?? 	Converter#
 [  ? ColumnDefinitions 5A      ?? 5B   "   $	??150 ?63   ?? 5C   "   ?? 5D   "   $	??100 ?63   .+?5F      ?? $	??150??5G   !   $	??150??6-   $??UniformToFill=?6:   ??5H   !   ?? *MainImagePath+  imageConverter#
 [ ?? 5I      $??7q?6)   $??1??64    ? 	Resources 5J   "    ?? 
TargetType  discountText ?? Triggers ?? Binding ?? Value ?? Property ?? Value??%?   &	       ?? 5K   &   " ??6,    5L   *   ?? 5M   .    6:   ?? *
Discount+ 06W   .a?5N   2   ??  ? y?$ 	Collapsed=?6O   5O   /   5Q   '   5R   #   .+?5S   "   ?? $??22(?6,   $
??Wrap=?6:   ?? 5T   &   $??SemiBold"?6*   ?6@   ?? *Title+?? 5U   &   ?? 5V   &   ?6*   ?? *Cost+ ?? StringFormat$ {0:0.00}?? ?? TextDecorations 5W   )   ?? *
Discount+  discountToStrokeConverter#
 [  ?? 5X   &   #???  60   ??5Y   )   ?? *CostWithDiscount+$ {0:0.00}??$ OneWay=? рублей за ?? 5[   &   ?6*   ?? *DurationInMinutes+$ OneWay=? минут?? 5\   0   ?? 5]      $??14(?6(   #???  66   * скидка ?? 5^   +   ?6/   ?? *DiscountChanged+$ OneWay=?%5_      5`      ?? 5a   "   -   5        $??20q?5a   *   $??Записать??5b      y?60   ??  ?? ElementName$ servicePage?? ?? Path$ IsAdmin?  	 BooleanToVisibilityConverter#
 [	 5c      ?? 5d      $??2??6)   $??3q?69   $	??Top=?6E   y?6]   ?? $ servicePage??$ IsAdmin?#
 [	 .+?5e   "   ?? -   5        $??0 0 0 2q?5e   )    
 MaterialDesignFlatButton#??? 
 6N   .??5f   &     $
 Edit=?6>   5g   #   ?? 5h   "   -	   5        #??? 
 5h   )   .??5i   &     $ Remove=?6>   5j   #   5k      5l      5m      5o      5p      5q      5r      