   M S B A M L   `   `   `  ����U  QStudent Information System, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Student_Information_SystemStudent_Information_System  5      6    0Student_Information_System.GenerateReportControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:Student_Information_System     5      -   5          >�Name$  generateReportControl��5      $	��594��5   7   $	��395��6C   .��5	      � $��
0,0,10,9.6q�6   
�������$	��594��62   $	��395��6>   .+�5
   
   �� $��Enrollment Report��6   $
��Left=�6,   $��	40,32,0,0q�6G   $	��Top=�6Z   $��Arial)�6r   $��20(�6�   $
��Bold"�6�   �� 5   
   -   5         ��Name$ stuAddressLabel��5      $��Address��6)   $
��Left=�6;   $��
40,152,0,0q�6V   $	��Top=�6j    J� RenderTransformOrigin$ 0.033,0.263&�6�   $��Arial)�6�   $��0q�6�   $��15��6�   $��10(�6�   ���	#FF6E6E6E$
��Bold"�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ courseCountTable��5      $
��Left=�6-   $	��248��6H   $��	40,83,0,0q�6U   $	��Top=�6h   $	��499��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Course��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 300 65   -   5        courseColumn��1  +System.Windows.Controls.DataGridBoundColumn   Binding 5   W   �� *
CourseName+  5      $ No. of students��6%   $	 199 6>   -   5        studentCountColumn�� 5   f   �� *StudentsCount+5      �� 5   
   -   5         ��Name$ 
refreshBtn��5      $��Refresh��6%   $
��Left=�67   $��
410,32,0,0q�6R   $	��Top=�6f   $	��129��6~   $��34��6�   $��Arial)�6�   ���	#FF3E206D
�������$
��Bold"�6�   	 � Cursor$
	 Hand��6  ��6�   Z� 6  5      5      