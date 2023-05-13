using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows;
using System.Collections.ObjectModel;

namespace Student_Information_System
{
    class FileIO
    {
        public static ObservableCollection<Student> Students { get; set; }


        private string filePath = Directory.GetCurrentDirectory() + @"\students.dat";
        private BinaryFormatter bf = new BinaryFormatter();

        public FileIO()
        {
            Students = new ObservableCollection<Student>();

            Students = getData();
            
            //saveData(582, "Sangam Dai", "Parshyang");
        }

        public void saveData(int studentID, string studentName, string studentAddress, string studentPhone, string courseEnrolled, DateTime regDate)
        {
            Students.Add(new Student(studentID, studentName, studentAddress, studentPhone, courseEnrolled, regDate));

            using (Stream stream = new FileStream(filePath, FileMode.Create))
            {
                bf.Serialize(stream, Students);

                stream.Close();
            }

                
        }

        public ObservableCollection<Student> getData()
        {
            if (File.Exists(filePath))
            {
                using (Stream stream = File.Open(filePath, FileMode.Open))
                {
                    Students = (ObservableCollection<Student>)bf.Deserialize(stream);

                    stream.Close();
                }

                    
            }

            return Students;
        }

        public void displayData()
        {
            for (int i = 0; i < Students.Count; i++)
            {
                Console.WriteLine("\n---------------+++++++---------------\n");
                Console.WriteLine("ID: " + Students[i].StudentID);
                Console.WriteLine("Name: " + Students[i].StudentName);
                Console.WriteLine("Address: " + Students[i].StudentAddress);
            }
        }

        public void exportCSV(string path)
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(path, true))
                {
                    for (int i = 0; i < Students.Count; i++)
                    {
                        file.WriteLine(Students[i].StudentID + "," + Students[i].StudentName + "," + Students[i].StudentAddress + "," + Students[i].StudentPhone + "," + Students[i].CourseEnrolled + "," + Students[i].RegDate);
                        //file.WriteLine(12 + "," + "Sangam BK" + "," + "Parsyang");
                    }
                    //file.WriteLine(fullName + "," + address + "," + age);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("File cannot be saved.", ex);
            }
        }

        public void importCSV(string path)
        {

            string[] data = System.IO.File.ReadAllLines(path);

            try
            {
                for (int i = 0; i < data.Length; i++)
                {
                    string[] details = data[i].Split(',');

                    saveData(int.Parse(details[0]), details[1], details[2], details[3], details[4], Convert.ToDateTime(details[5]));
                    //Students.Add(new Student(int.Parse(details[0]), details[1], details[2]));
                }

                MessageBox.Show("Imported successfully!");
            } catch (Exception ex)
            {
                MessageBox.Show("Error importing data!" + ex.Message);
            }
            
        }
    }
}
