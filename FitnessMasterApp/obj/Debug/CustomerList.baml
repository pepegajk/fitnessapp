   M S B A M L   `   `   `  ����  FitnessMasterApp#    FitnessMasterApp.CustomerList   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$#  Список клиентов��5   	   $	��600��6!   $	��900��6.   .��5      � .+�5   
   �� $��ФитнесМас��6   $��24(�6%   $
��Bold"�63   $��Center=�6E   $	��Top=�6b   $��0,20,0,0q�6z   �� 5   
   $#��Список клиентов��6   $��18(�6+   $��Center=�69   $	��Top=�6V   $��0,60,0,0q�6n   �� 5   
    �� Orientation$ 
Horizontal=�6   $
��Left=�6.   $	��Top=�6I   $��
20,100,0,0q�6a   .+�5      �� -   5        $��SearchTextBox��5      $	��300��6+   $��30��67   �� 5      -   5        $��Искать��5      $	��100��6&   62   5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��ClientsDataGrid��5      $��20,150,20,100q�6*      AutoGenerateColumns .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Номер клиента��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6Y   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   �� *
ClientID+6Y     5      $ ФИО клиента��6%   $	 200 6W    6:   �� *
FullName+6W     5      $ Дата рождения��6%   $	 150 6Z    6<   �� *	BirthDate+6Z     5      $! Номер телефона��6%   $	 150 6W    6=   �� *Phone+6W     5      $ 
Почта��6%   $	 200 6N    64   �� *Email+6N     5      $! Тип абонемента��6%   $	 150 6`    6=   �� *MembershipType+6`     5      $' !Статус абонемента��6%   $	 150 6e    6@   �� *MembershipStatus+6e     5      $ Номер группы��6%   $	 100 6W    6;   �� *	GroupID+6W   5      �� 5   
   $ 
Horizontal=�6   $��Center=�6.   $��Bottom=�6K   $��0,0,0,20q�6f   .+�5       �� -   5        $��Изменить��5       $	��100��6(   64   �� 5!      -   5        $��Удалить��5!      $	��100��6'   63   �� 5"      -   5        $��
Назад��5"      $	��100��6%   61   5#      5$      5%      