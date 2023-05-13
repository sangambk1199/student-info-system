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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    ///     

    partial class MainWindow : Window
    {
        private UserControl activeControl;
        private Button activeButton;

        public MainWindow()
        {
            InitializeComponent();
            activeButton = addRecordBtn;
            activeControl = addStudentControl;
        }

        private void closeBtn_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void studentDetailsBtn_Click(object sender, RoutedEventArgs e)
        {
            changeUserControl((sender as Button), studentDetailControl); 
        }

        private void addRecordBtn_Click(object sender, RoutedEventArgs e)
        {
            changeUserControl((sender as Button),addStudentControl);
        }

        private void importBtn_Click_1(object sender, RoutedEventArgs e)
        {
            changeUserControl((sender as Button), importControl);
        }

        private void reportBtn_Click(object sender, RoutedEventArgs e)
        {
            changeUserControl((sender as Button), generateReportControl);
        }

        private void courseEnrollmentBtn_Click(object sender, RoutedEventArgs e)
        {
            changeUserControl((sender as Button), courseEnrollmentControl);
        }

        private void changeUserControl(Button clickedButton, UserControl clickedControl)
        {
            //clickedButton.Background = Brushes.Red;
            activeButton.Background = null;
            clickedButton.Background = new SolidColorBrush(Color.FromRgb(43, 14, 89));

            activeControl.Visibility = Visibility.Hidden;
            clickedControl.Visibility = Visibility.Visible;

            activeControl = clickedControl;
            activeButton = clickedButton;
        }

        /*private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }*/

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
