   M S B A M L   `   `   `  ����K  GFitnessMasterApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:FitnessMasterAppFitnessMasterApp  5   	       FitnessMasterApp.Reports   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:FitnessMasterApp     5   	     � Title$  Reports��5   	   $	��450��6   $	��800��6&   .��5	      � .+�5   
   �� $��ФитнесМас��6   $��24(�6%   $
��Bold"�63   $
��Left=�6E   $	��Top=�6`   $��0,20,0,0q�6x   �� 5   
   $��Отчеты��6   $��18(�6"   $
��Left=�60   $	��Top=�6K   $��0,60,0,0q�6c   &   System.Windows.Controls.DataGrid  5   
   -   5        $��ReportsDataGrid��5      $��20,150,20,100q�6*      AutoGenerateColumns .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ номер отчета��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6X   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *
ReportID+6X     5      $ фио клиента��6%   $	 100 6Y    6:   �� *
ReportName+6Y     5      $ Дата продажи��6%   $	 150 6\    6;   �� *CreationDate+6\     5      $ Тип продажи��6%   $	 150 6Y    6:   �� *
ReportType+6Y     5      $ сумма продажи��6%   $	 150 6X    6<   �� *sumrep+6X   5      �� 5   
    �� Orientation$ 
Horizontal=�6   $��Center=�6.   $��Bottom=�6K   $��0,0,0,20q�6f   .+�5      �� -   5        $��Экспорт��5      $	��100��6'   63   �� 5      -   5        $��Импорт��5      $	��100��6&   62   �� 5       -   5        $��
Назад��5       $	��100��6%   61   �� 5!      -   5        $��Фильтровать��5!      $	��100��6+   67   5"      5#      5$      