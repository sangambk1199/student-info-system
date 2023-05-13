using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
    /// Interaction logic for StudentDetailControl.xaml
    /// </summary>
    public partial class StudentDetailControl : UserControl
    {
        private FileIO fileIO = new FileIO();
        ObservableCollection<Student> students;
        public StudentDetailControl()
        {
            InitializeComponent();
            fillTable();
        }

        private void fillTable()
        {
            try
            {
                studentDetailTable.ItemsSource = null;
                students = fileIO.getData();
                studentDetailTable.ItemsSource = students;
            }
            catch
            {
                MessageBox.Show("An error occured!");
            }            
        }

        private void refreshStudentBtn_Click(object sender, RoutedEventArgs e)
        {
            fillTable();
        }

        private void sortByName_Checked(object sender, RoutedEventArgs e)
        {
            SortDataGrid(studentDetailTable,1);
        }

        private void sortByDate_Checked(object sender, RoutedEventArgs e)
        {
            SortDataGrid(studentDetailTable, 5);
        }

        public static void SortDataGrid(DataGrid dataGrid, int columnIndex = 0, ListSortDirection sortDirection = ListSortDirection.Ascending)
        {
            var column = dataGrid.Columns[columnIndex];

            // Clear current sort descriptions
            dataGrid.Items.SortDescriptions.Clear();

            // Add the new sort description
            dataGrid.Items.SortDescriptions.Add(new SortDescription(column.SortMemberPath, sortDirection));

            // Apply sort
            foreach (var col in dataGrid.Columns)
            {
                col.SortDirection = null;
            }
            column.SortDirection = sortDirection;

            // Refresh items to display sort
            dataGrid.Items.Refresh();
        }
    }
}
