   M S B A M L   `   `   `  ����U  QStudent Information System, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Student_Information_SystemStudent_Information_System  5   	   +    %Student_Information_System.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:Student_Information_System     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � WindowStyle$
 None=�65   .��5	      � -   5        .+�5
   
   � $
��Left=�6   $	��443��6*   $	��Top=�67   $	��200��6O   ���	#FF3E206D.+�5      �� -   5         ��Name$ addRecordBtn��5      $��Add new student��6+   $��	0,113,0,0q�6E   $	��Top=�6X   $��38��6p   ���	#FF2B0E59
������� � Cursor$
 Hand��6�   $��Vollkorn)�6�   $��13(�6�   ��6�   Z� 6�   �� 5      -   5        $ studentDetailsBtn��5      $��Student Details��60   $��
0,151,-1,0q�6J   $	��Top=�6^   $��38��6v   ���	#FF3E206D
�������$
 Hand��6�   $��Vollkorn)�6�   $��13(�6�   ��6�   Z� 6�   �� 5      -   5        $ 	importBtn��5      $��Import/Export��6(   $��	0,189,0,0q�6@   $	��Top=�6S   $��38��6k   ���	#FF3E206D
�������$
 Hand��6�   $��Vollkorn)�6�   $��13(�6�   ��6�   Z� 6�   �� 5      -   5        $ 	reportBtn��5      $��Weekly Report��6(   $��	0,227,0,0q�6@   $	��Top=�6S   $��38��6k   ���	#FF3E206D
�������$
 Hand��6�   $��Vollkorn)�6�   $��13(�6�   ��6�   Z� 6�   �� 5      -   5        $ courseEnrollBtn��5      $��Course Enrollment��6.   $��	0,265,0,0q�6J   $	��Top=�6]   $��38��6u   ���	#FF3E206D
�������$
 Hand��6�   $��Vollkorn)�6�   $��13(�6�   ��6�   Z� 6�   5      � 5   
   $
��Left=�6   $	��395��6*   $��200,48,-0.4,0q�67   $	��Top=�6N   $	��594��6f   .+�5      2   ,Student_Information_System.AddStudentControl  -   5          Name$ addStudentControl��5   &   $
��Left=�6A   $	��395��6\   $	��Top=�6i   $	��594��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   $��0,4,0,-4q�6�   z�5      V� 5      .~�5      �� �� 5       �� AngleY$ 0.231Q�6(   �� 5      T� 5       T� Y$ -1.196Q�6-   5      5      5   /Student_Information_System.StudentDetailControl  5      -   5          Name$ studentDetailControl��5   )   $
��Left=�6G   $	��395��6b   $	��Top=�6o   $	��594��6�   $y�Hidden=�6�   .   (Student_Information_System.ImportControl  5      -	   5        	  Name$	 importControl��5   "   $
��Left=�69   $	��395��6T   $	��Top=�6a   $	��594��6y   $y�Hidden=�6�   6   0Student_Information_System.GenerateReportControl  5      -
   5        
  Name$
 generateReportControl��5   *   $
��Left=�6I   $	��395��6d   $	��Top=�6q   $	��594��6�   $y�Hidden=�6�   8   2Student_Information_System.CourseEnrollmentControl  5      -   5          Name$ courseEnrollmentControl��5   ,   $
��Left=�6M   $	��395��6h   $	��Top=�6u   $	��594��6�   $y�Hidden=�6�   5       � 5!   
   -   5         �Name$ menuBarGrid��5!      $
��Left=�6$   $��48��6?   $��205,0,-0.4,0q�6K   $	��Top=�6a   $	��589��6y   .+�5"      �� -   5        $ closeBtn��5"      $��x��6'   $
��Left=�63   $��	549,8,0,0q�6N   $	��Top=�6a   $��30��6y   $��30��6�   
���  ��
�������$��0q�6�   $��Center=�6�   $��22(�6  $��0q�6  $��Arial)�62  ��6�   Z� 62  5#      5$      5%      