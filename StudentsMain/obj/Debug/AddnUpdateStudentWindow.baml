   M S B A M L   `   `   `  ����G  CStudentsMain, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:StudentsMainStudentsMain  5   	   K*clr-namespace:StudentsMain.ValidationRulesStudentsMain.ValidationRules  5   	   *    $StudentsMain.AddnUpdateStudentWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:StudentsMain     5   	   A
localrules*clr-namespace:StudentsMain.ValidationRules     5   	     � Title$  AddnUpdateStudentWindow��5	   	   $	��300��6)   $	��300��66    � 
ResizeMode$ NoResize=�6B    � 	Resources 5
         TbErrorTemplateStyle �� 
TargetType �� Property �� Value��%"  &	        �� 5   
   " ��6-   .�5      ��  �@=�ErrorTemplate 5      �� 5      .R�5      �� .+�5      �� 
���  ��$��3q�67   ._�5   "   �� 6>   5      �� 5      
���  ����6(   �� *[0].ErrorContent+6]   5      5      5      5      5      .��5      � $��5q�6    � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5       �� 5!       � ColumnDefinitions 5#   
   �� 5$      $��* �6   �� 5%      $��2* �6   .+�5'   
   �� -   5         ��Name$ LabelID��5'      $��2��6!   $��Center=�65   .��6S   ID6Y   �� 5(   
   $��1��6   .��6   
First name6)   �� 5)   
   $��2��6   .��6   	Last name6(   �� 5*   
   $��3��6   .��6   Age6"   �� 5+   
   $��4��6   .��6   Gender6%   �� 5,   
   -   5        	 ��Name$	 tbFirstName��5,      $��1��6'   $��1��67   $��20��6D   #��[  6P   .��6~   ��5-      �� 5.      
 �� Path$
 	FirstName�6    �� UpdateSourceTrigger$ PropertyChanged=�6+    �� ValidationRules 5/      +  %StudentsMain.ValidationRules.NameRule  50      ,  &System.Windows.Controls.ValidationRule   ValidatesOnTargetUpdated . 6.   52      .��53      54      �� 55   
   -   5        $	 
tbLastName��55      $��1��6&   $��2��66   $��20��6C   #��[  6O   .��6}   ��56      �� 57      $
 LastName�6   $ PropertyChanged=�6*    58        59       . 63   5;      .��5<      5=      �� 5>   
   -   5        $	 tbAge��5>      $��1��6!   $��3��61   $��20��6>   #��[  6J   .��6x   ��5?      �� 5@      $	
 Age�6   $ PropertyChanged=�6%    5A      *  $StudentsMain.ValidationRules.AgeRule  5B      5D      .��5E      5F      � 5G   
   $��Center=�6   $��Center=�61   $��1��6L   $��4��6\   .+�5H      	� $	��5,0q�6    d� 	IsChecked 6'   �� *Gender+$ PropertyChanged=� �� Mode$ TwoWay=�.��6w   Female6   	� 5I      $	��5,0q�6    6'   �� *	GenderM+.��6F   Male6L   5J      � 5K   
   $��5��6   $��2��6!   $��Center=�65   $��Center=�6R   .+�5L      �� -   5        $��70��5L      $
��10,0q�6    $��OK��6E   ��5M      �� 5N      " ��6    �� Triggers 5O      �� 5P       �� Binding 6*   ��  �� ElementName$ tbFirstName��$
 (Validation.HasError)� �� Value true6r   .a�5Q   "   ��  � {� .  6>   5R      �� 5S       6*   �� $ 
tbLastName��$
 (Validation.HasError)� true6q   .a�5T   "   ��  � {� .  6>   5U      �� 5V       6*   �� $ tbAge��$
 (Validation.HasError)� true6l   .a�5W   "   ��  � {� .  6>   5X      5Z      5\      �� 5]      -   5        $��70��5]      $
��10,0q�6    .��6I   Cancel6Q   5^      5_      5`      