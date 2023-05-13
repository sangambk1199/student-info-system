using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Student_Information_System
{
    /// <summary>
    /// Interaction logic for AddStudentControl.xaml
    /// </summary>
    public partial class AddStudentControl : UserControl
    {
        private FileIO fileIO = new FileIO();
        public AddStudentControl()
        {
            InitializeComponent();
        }

        private void submitStudentBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int studentID = int.Parse(stuIDTB.Text);
                string studentName = stuNameTB.Text;
                string studentAddress = stuAddressTB.Text;
                string studentPhone = stuPhoneTB.Text;
                string courseEnrolled = stuCourseCB.Text;
                DateTime regDate = registrationDP.DisplayDate;


                if (studentName != "" && studentAddress != "" && studentPhone != "" && courseEnrolled != "")
                {
                    fileIO.saveData(studentID, studentName, studentAddress, studentPhone, courseEnrolled,regDate);

                    MessageBox.Show("Data saved successfully!");
                }
                else
                {
                    MessageBox.Show("One or more fields are empty. Please fill in all the information.");
                }
            } catch
            {
                MessageBox.Show("Invalid Student ID!");
            }

            
        }
    }
}
