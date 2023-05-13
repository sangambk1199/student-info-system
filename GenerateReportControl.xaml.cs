using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for GenerateReportControl.xaml
    /// </summary>
    public partial class GenerateReportControl : UserControl
    {
        private FileIO fileIO = new FileIO();
        ObservableCollection<Student> students;
        private IDictionary<string, int> studentCounter = new Dictionary<string, int>();

        public GenerateReportControl()
        {
            InitializeComponent();
            fillTable();
        }
        
        public void countStudents()
        {
            students = fileIO.getData();
            studentCounter["BBA"] = studentCounter["BBS"] = studentCounter["BIT"] = studentCounter["BCA"] = studentCounter["others"] = 0;

            for (int i = 0; i < students.Count; i++)
            {
                switch (students[i].CourseEnrolled)
                {
                    case "BBA":
                        studentCounter["BBA"]++;
                        break;
                    case "BCA":
                        studentCounter["BCA"]++;
                        break;
                    case "BIT":
                        studentCounter["BIT"]++;
                        break;
                    case "BBS":
                        studentCounter["BBS"]++;
                        break;
                    default:
                        studentCounter["others"]++;
                        break;                           
                }
            }            
        }

        public void fillTable()
        {
            countStudents();

            courseCountTable.Items.Add(new { CourseName = "BIT", StudentsCount = studentCounter["BIT"] });
            courseCountTable.Items.Add(new { CourseName = "BBA", StudentsCount = studentCounter["BBA"] });
            courseCountTable.Items.Add(new { CourseName = "BCA", StudentsCount = studentCounter["BCA"] });
            courseCountTable.Items.Add(new { CourseName = "BBS", StudentsCount = studentCounter["BBS"] });
        }

        private void refreshBtn_Click(object sender, RoutedEventArgs e)
        {
            courseCountTable.Items.Clear();

            fillTable();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
