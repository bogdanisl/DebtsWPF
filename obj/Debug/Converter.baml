   M S B A M L   `   `   `  ����@  <Debts, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:DebtsDebts  5   	       Debts.Converter   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Debts     5   	   U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   a ]Syncfusion.Shared.Wpf, Version=18.1460.0.56, Culture=neutral, PublicKeyToken=3d67ed1f87d44c892
syncfusion!http://schemas.syncfusion.com/wpf  5	   	     � Title$  	Converter��5
   	   $��262.53��6   $��220.513��6+    � 
ResizeMode$ NoResize=�6;    � WindowStyle$
 None=�6Q   '  !System.Windows.Shell.WindowChrome   WindowChrome 5        5   
      CaptionHeight$ 0Q�6   .��5      �� .+�5   
   ]� -   5         ]�Name$ TopPanel��5      ��.  .+�5      �� -   5         ��Name$ ButtonClose��5      $��Right=�6*    0  ,MaterialDesignFloatingActionMiniAccentButton#��[  6A   $��25��6�   $��25��6�   
���������6�   Z� ��6�   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=null]]   Kind$ Close=�6*   5      5      �� 5   
   $��Enigmatic Unicode)�6   $��20(�63   �� 5      $�USD: ��6   6!    �� 5      -   5         �Name$	 usd��5      6   �� 5      �� 5      $�EUR: ��6   6!    �� 5      -   5        $	 eur��5      6   �� 5      �� 5      $�RUB: ��6   6!    �� 5      -   5        $	 rub��5      6   �� 5      �� 5      -   5        	 ��Name$	 SelectedCurrency��5   $   $	��0,5q�6   .@�5      �� .��6   UAH6$   �� 5       .��6   USD6$   �� 5!      .��6   EUR6$   �� 5"      .��6   RUB6$   5#      �� 5$      �� 5%      $
�UAH:��6    &   Syncfusion.Windows.Shared.UpDown  5&      -   5        $��	upDownUAH��5&   -   $	��4,0q�6    $	��100��6>   $��23��6J   
   MinValue$
 0Q�6V   6c   �� 5'      �� 5(      $
�USD:��6      5)      -   5        $��	upDownUSD��5)   -   $	��5,0q�6    $	��100��6>   $��23��6J   $
 0Q�6V   6c   �� 5*      �� 5+      $
�EUR:��6      5,      -	   5        $��	upDownEUR��5,   -   $	��7,0q�6    $	��100��6>   $��23��6J   $
 0Q�6V   6c   �� 5-      �� 5.      $
�RUB:��6      5/      -
   5        $��	upDownRUB��5/   -   $	��5,0q�6    $	��100��6>   $��23��6J   $
 0Q�6V   6c   50      51      52      