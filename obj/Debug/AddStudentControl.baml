   M S B A M L   `   `   `  ����U  QStudent Information System, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Student_Information_SystemStudent_Information_System  5      2    ,Student_Information_System.AddStudentControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:Student_Information_System     5      $	��594��5   7   $	��395��6C   .��5	      � -   5          �Name$  addStudentControl��5	      
�������$	��594��69   $	��395��6E   .+�5
   
   �� -   5         ��Name$ stuIDTB��5
      $
��Left=�6#   $��29��6>   $��	40,98,0,0q�6J    �� TextWrapping$
 Wrap=�6]   $	��Top=�6q   $	��198��6�   �� 5   
   -   5         ��Name$ 
stuIDLabel��5      $��
Student ID��6$   $
��Left=�69   $��	40,83,0,0q�6T   $	��Top=�6g    J� RenderTransformOrigin$ 0.033,0.263&�6   $��Arial)�6�   $��0q�6�   $��15��6�   $��10(�6�   ���	#FF6E6E6E$
��Bold"�6�   �� 5   
   $��Add New Student��6   $
��Left=�6*   $��	40,32,0,0q�6E   $	��Top=�6X   $��Arial)�6p   $��20(�6�   $
��Bold"�6�   �� 5   
   -   5        $ 	stuNameTB��5      $
��Left=�6%   $��29��6@   $��
281,98,0,0q�6L   $
 Wrap=�6`   $	��Top=�6t   $	��198��6�   �� 5   
   -   5        $ stuNameLabel_Copy��5      $��	Full Name��6+   $
��Left=�6?   $��
281,83,0,0q�6Z   $	��Top=�6n   $ 0.033,0.263&�6�   $��Arial)�6�   $��0q�6�   $��15��6�   $��10(�6�   ���	#FF6E6E6E$
��Bold"�6�   �� 5   
   -   5        $ stuAddressTB��5      $
��Left=�6(   $��29��6C   $��
40,167,0,0q�6O   $
 Wrap=�6c   $	��Top=�6w   $	��198��6�   �� 5   
   -   5        $ stuAddressLabel��5      $��Address��6)   $
��Left=�6;   $��
40,152,0,0q�6V   $	��Top=�6j   $ 0.033,0.263&�6�   $��Arial)�6�   $��0q�6�   $��15��6�   $��10(�6�   ���	#FF6E6E6E$
��Bold"�6�   �� 5   
   -   5        $ 
stuPhoneTB��5      $
��Left=�6&   $��29��6A   $��281,167,0,0q�6M   $
 Wrap=�6b   $	��Top=�6v   $	��198��6�   �� 5   
   -	   5        $ stuPhoneLabel��5      $��Phone Number��6'   $
��Left=�6>   $��281,152,0,0q�6Y   $	��Top=�6n   $ 0.033,0.263&�6�   $��Arial)�6�   $��0q�6�   $��15��6�   $��10(�6�   ���	#FF6E6E6E$
��Bold"�6�   �� 5   
   -
   5        $ stuCourseLabel��5      $��Course Enroll��6(   $
��Left=�6@   $��
40,219,0,0q�6[   $	��Top=�6o   $ 0.033,0.263&�6�   $��Arial)�6�   $��0q�6�   $��15��6�   $��10(�6�   ���	#FF6E6E6E$
��Bold"�6�   �� 5   
   -   5         ��Name$ stuCourseCB��5      $
��Left=�6(   $��
40,234,0,0q�6C   $	��Top=�6W   $	��198��6o   $��28��6{   ���	#FF171717��6�   Z� .@�5      �� -   5         ��Name$ comboItemBIT��5      $	��BIT��61   $
��Left=�6?   $��196.8��6Z   �� 5      -   5        $ comboItemBBA��5      $	��BBA��61   $
��Left=�6?   $��196.8��6Z   �� 5      -   5        $ comboItemBCA��5      $	��BCA��61   $
��Left=�6?   $��196.8��6Z   �� 5      -   5        $ comboItemBBS��5      $	��BBS��61   $
��Left=�6?   $��196.8��6Z   5      �� 5   
   -   5         ��Name$ submitStudentBtn��5      $��Add Student��6+   $
��Left=�6A   $��
40,293,0,0q�6\   $	��Top=�6p   $	��198��6�   $��34��6�   $��Arial)�6�   ���	#FF3E206D
�������$
��Bold"�6�    � Cursor$
 Hand��6%  ��6�   Z� 6%  �� 5   
   -   5        $ registrationDateLabel��5      $��Registration Date��6/   $
��Left=�6K   $��281,219,0,0q�6f   $	��Top=�6{   $ 0.033,0.263&�6�   $��Arial)�6�   $��0q�6�   $��15��6�   $��10(�6�   ���	#FF6E6E6E$
��Bold"�6  (  "System.Windows.Controls.DatePicker  5   
   -   5        	  Name$	 registrationDP��5      $
��Left=�6-   $��281,234,0,0q�6H   $	��Top=�6]   $��29��6u   $	��198��6�   5      5      