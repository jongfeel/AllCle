   M S B A M L   `   `   `  ����?  ;test, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:testtest  5   	       test.MainScreen   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:test     5   	     � Title$  AllCle��5   	   $��635.1��6   $��951.2��6'   .��5	      � .+�5   
   �� -   5        $��
Search_Box��5      $
��Left=�6$   $��19��6?   $��234,351,0,0q�6K    �� TextWrapping$
 Wrap=�6`   $��	과목명��6t   $	��Top=�6   $	��117��6�   6�   �� 5   
   -   5        $��
Search_btn��5      $��검색��6#   $
��Left=�60   $��19��6K   $��351,351,0,0q�6W   $	��Top=�6l   $��43��6�   6�   �� 5   
   -   5         ��Name$ MyGroup_btn��5      $��MyGroup��6&   $
��Left=�68   $��19��6S   $��464,351,0,0q�6_   $	��Top=�6t   $	��132��6�   �� 5   
   -   5        $ jol_btn��5      $��졸업요건��6"   $
��Left=�61   $��19��6L   $��596,351,0,0q�6X   $	��Top=�6m   $	��132��6�   �� 5   
   $��Button��6   $
��Left=�6"   $��19��6=   $��728,351,0,0q�6I   $	��Top=�6^   $��74��6v   �� 5   
   -   5        $ save_btn��5      $��저장��6#   $
��Left=�60   $��19��6K   $��802,351,0,0q�6W   $	��Top=�6l   $��72��6�   �� 5   
   $
��Left=�6   $	��100��6+   $	��Top=�68   $	��100��6P   � 5   
   $��230,375,-0.2,-0.4q�6   �� 5   
   -   5        $ 	OnOff_btn��5      $��전체��6$   $
��Left=�61   $��19��6L   $��399,351,0,0q�6X   $	��Top=�6m   $��60��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	TimeTable��5      $
��Left=�6F   $	��336��6a   $��
230,10,0,0q�6n   $	��Top=�6�   $	��650��6�      HorizontalGridLinesBrush
 �   �   VerticalGridLinesBrush
 �   �   	RowHeight$ 40Q�6�      
IsReadOnly .    AutoGenerateColumns .  ��6&   �� *	DayList+	 � ContextMenu	 5      �� 5      
 � 	Resources
 5      ��%    5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 교시��6A      Width5  /System.Windows.Controls.DataGridLengthConverter$ 40 6M   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *period+6[     5      $	 월��6=   $	 100 6H    6%   �� *mon+6W     5      $	 화��6=   $	 100 6H    6%   �� *tue+6V     5      $	 수��6=   $	 100 6H    6%   �� *wed+6V     5       $	 목��6=   $	 100 6H    6%   �� *thu+6V     5!      $	 금��6=   $	 100 6H    6%   �� *fri+6V     5"      $	 토��6=   $	 100 6H    6%   �� *sat+6V   5$      �� 5(   
   -   5         ��Name$ DataListView��5(      $
��Left=�6)   $	��231��6D   $��230,375,-0.2,-0.4q�6Q   $	��Top=�6l   $	��715��6�   ��6�   �� *aList+ �� View 5)      �� 5*      .P�5+      �� $��NO��6I    �� Width$ 50��6U    �� DisplayMemberBinding 6%   �� *NO+6b   �� 5,      $��학년��6L   $ 50��6X    6%   �� *Grade+6e   �� 5-      $��학수번호��6R   $	 150��6`    6%   �� *ClassNumber+6n   �� 5.      $��	과목명��6P   $	 100��6]    6%   �� *	ClassName+6k   �� 5/      $��학점��6S   $ 50��6_    6%   �� *CreditCourse+6l   �� 50      $��	교수명��6P   $	 200��6]    6%   �� *	Professor+6k   �� 51      $��강의시간��6K   $ 80��6Y    6%   �� *강의시간+6f   �� 52      53      55      57      58      