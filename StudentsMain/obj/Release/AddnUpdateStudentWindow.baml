   M S B A M L   `   `   `  ���� G  CStudentsMain, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:StudentsMainStudentsMain  K*clr-namespace:StudentsMain.ValidationRulesStudentsMain.ValidationRules  *    $StudentsMain.AddnUpdateStudentWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     ,localclr-namespace:StudentsMain     A
localrules*clr-namespace:StudentsMain.ValidationRules       � Title$  AddnUpdateStudentWindow��$	��300��$	��300�� � 
ResizeMode$ NoResize=� � 	Resources    TbErrorTemplateStyle �� 
TargetType �� Property �� Value��%�   &	        �� " ��.���  �@=�ErrorTemplate �� .R��� .+��� 
���  ��$��3q�._��� �� 
���  ������ *[0].ErrorContent+.��� $��5q� � RowDefinitions �� �� �� �� �� ��  � ColumnDefinitions �� $��* ��� $��2* �.+��� -    ��Name$ LabelID��$��2��$��Center=�.��ID�� $��1��.��
First name�� $��2��.��	Last name�� $��3��.��Age�� $��4��.��Gender�� -   	 ��Name$	 tbFirstName��$��1��$��1��$��20��#��[  .������ 
 �� Path$
 	FirstName� �� UpdateSourceTrigger$ PropertyChanged=� �� ValidationRules +  %StudentsMain.ValidationRules.NameRule  ,  &System.Windows.Controls.ValidationRule   ValidatesOnTargetUpdated . .���� -   $	 
tbLastName��$��1��$��2��$��20��#��[  .������ $
 LastName�$ PropertyChanged=�    . .���� -   $	 tbAge��$��1��$��3��$��20��#��[  .������ $	
 Age�$ PropertyChanged=� *  $StudentsMain.ValidationRules.AgeRule  .��� $��Center=�$��Center=�$��1��$��4��.+�	� $	��5,0q� d� 	IsChecked �� *Gender+$ PropertyChanged=� �� Mode$ TwoWay=�.��Female	� $	��5,0q� �� *	GenderM+.��Male� $��5��$��2��$��Center=�$��Center=�.+��� -   $��70��$
��10,0q�$��OK������ " �� �� Triggers ��  �� Binding ��  �� ElementName$ tbFirstName��$
 (Validation.HasError)� �� Value true.a���  � {� .  ��  �� $ 
tbLastName��$
 (Validation.HasError)� true.a���  � {� .  ��  �� $ tbAge��$
 (Validation.HasError)� true.a���  � {� .  �� -   $��70��$
��10,0q�.��Cancel