   M S B A M L   `   `   `  ����K  GFitnessMasterApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:FitnessMasterAppFitnessMasterApp  5   	   $    FitnessMasterApp.ClassSchedule   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:FitnessMasterApp     5   	     � Title$  ClassSchedule��5   	   $	��450��6   $	��800��6,   .��5	      � .+�5   
   �� $��ФитнесМас��6   $��24(�6%   $
��Bold"�63   $
��Left=�6E   $	��Top=�6`   $��0,20,0,0q�6x   �� 5   
   $)��#Расписание занятий��6   $��18(�6.   $
��Left=�6<   $	��Top=�6W   $��0,60,0,0q�6o   �� 5   
    �� Orientation$ 
Horizontal=�6   $
��Left=�6.   $	��Top=�6I   $��
20,100,0,0q�6a   .+�5      �� -   5        $��TrainerFilter��5      $	��200��6,   $��30��68   �� 5      -   5        $��
RoomFilter��5      $	��150��6)   $��30��65   (  "System.Windows.Controls.DatePicker  5      -   5        $��
DateFilter��5      $	��150��6+   $��30��67   �� 5      -   5        $��Фильтровать��5      $	��100��6+   67   5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��ScheduleDataGrid��5      $��20,150,20,100q�6+      AutoGenerateColumns .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$% номер расписания��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 120 6[   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� *	ClassID+6[     5      $ номер зала��6%   $	 100 6W    69   �� *	ClassName+6W     5      $ Тренер��6%   $	 100 6U    65   �� *TrainerName+6U     5      $ номер группы��6%   $	 150 6X    6;   �� *
RoomName+6X     5      $ Дата и время��6%   $	 100 6Y    6;   �� *	ClassTime+6Y     5      $ клиент��6%   $	 100 6[    65   �� *ParticipantsCount+6[   5       �� 5#   
   $ 
Horizontal=�6   $��Center=�6.   $��Bottom=�6K   $��0,0,0,20q�6f   .+�5$      �� -   5        $��Добавить��5$      $	��100��6(   64   �� 5%      -   5        $��Изменить��5%      $	��100��6(   64   �� 5&      -   5        $��Удалить��5&      $	��100��6'   63   �� 5'      -	   5        $��
Назад��5'      $	��100��6%   61   5(      5)      5*      