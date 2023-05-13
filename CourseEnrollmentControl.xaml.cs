using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Reflection;

namespace Student_Information_System
{
    /// <summary>
    /// Interaction logic for CourseEnrollmentControl.xaml
    /// </summary>
    public partial class CourseEnrollmentControl : UserControl
    {
        private FileIO fileIO = new FileIO();
        ObservableCollection<Student> students;
        private IDictionary<string, int> studentCounter = new Dictionary<string, int>();
        public CourseEnrollmentControl()
        {
            InitializeComponent();
            displayChart();
        }

        public void displayChart()
        {
            countStudents();
            List<Bar> _bar = new List<Bar>();
            _bar.Add(new Bar() { BarName = "BIT", Value = studentCounter["BIT"] });
            _bar.Add(new Bar() { BarName = "BBA", Value = studentCounter["BBA"] });
            _bar.Add(new Bar() { BarName = "BCA", Value = studentCounter["BCA"] });
            _bar.Add(new Bar() { BarName = "BBS", Value = studentCounter["BBS"] });
            this.DataContext = new RecordCollection(_bar);
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

        private void refreshBtn_Click(object sender, RoutedEventArgs e)
        {
            displayChart();
        }
    }
}

class RecordCollection : ObservableCollection<Record>
    {

        public RecordCollection(List<Bar> barvalues)
        {
            Random rand = new Random();
            BrushCollection brushcoll = new BrushCollection();

            foreach (Bar barval in barvalues)
            {
                int num = rand.Next(brushcoll.Count / 3);
                Add(new Record(barval.Value, brushcoll[num], barval.BarName));
            }
        }

    }

    class BrushCollection : ObservableCollection<Brush>
    {
        public BrushCollection()
        {
            Type _brush = typeof(Brushes);
            PropertyInfo[] props = _brush.GetProperties();
            foreach (PropertyInfo prop in props)
            {
                Brush _color = (Brush)prop.GetValue(null, null);
                if (_color != Brushes.LightSteelBlue && _color != Brushes.White &&
                     _color != Brushes.WhiteSmoke && _color != Brushes.LightCyan &&
                     _color != Brushes.LightYellow && _color != Brushes.Linen)
                    Add(_color);
            }
        }
    }

    class Bar
    {

        public string BarName { set; get; }

        public int Value { set; get; }

    }

    class Record : INotifyPropertyChanged
    {
        public Brush Color { set; get; }

        public string Name { set; get; }

        private int _data;
        public int Data
        {
            set
            {
                if (_data != value)
                {
                    _data = value;

                }
            }
            get
            {
                return _data;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public Record(int value, Brush color, string name)
        {
            Data = value;
            Color = color;
            Name = name;
        }

        protected void PropertyOnChange(string propname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propname));
            }
        }
    }