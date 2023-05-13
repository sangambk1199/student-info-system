using Microsoft.Win32;
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
    /// Interaction logic for ImportControl.xaml
    /// </summary>
    public partial class ImportControl : UserControl
    {
        private FileIO fileIO = new FileIO();
        public ImportControl()
        {
            InitializeComponent();
        }

        private void exportStudentsBtn_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog exportData = new SaveFileDialog();
            exportData.Title = "Export Students Detail";
            exportData.FileName = "students_something";
            exportData.Filter = "CSV File|*.csv";

            if (exportData.ShowDialog() == true)
            {
                string path = exportData.FileName;
                fileIO.exportCSV(path);
                MessageBox.Show("File saved succesfully!");
            }
        }

        private void importStudentsBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog importData = new OpenFileDialog();
            importData.Title = "Import Students";
            importData.Filter = "CSV File|*.csv";

            if(importData.ShowDialog() == true)
            {
                string path = importData.FileName;

                fileIO.importCSV(path);
            }
        }
    }
}
