using System;
using System.Collections.Generic;
using System.IO;
<<<<<<< HEAD

namespace Turniket_OOP
{    static class Facultet
    {
        public static List<Student> Readfile() 
        {
            using (StreamReader sr = new StreamReader("group.txt"))
=======
using System.Text;

namespace Turniket_OOP
{
    class Facultet
    {
        private static List<Student> students = new List<Student>();

        public static List<Student> Students { get => students; set => students = value; }

        static Facultet()
        {
            students.AddRange(ReadFile("D:\\Turniket_OOP/Turniket_OOP/IS-81.txt", "IS-81"));
            students.AddRange(ReadFile("D:\\Turniket_OOP/Turniket_OOP/IS-82.txt", "IS-82"));
        }

        private static List<Student> ReadFile(string path, string group)
        {
            List<Student> students = new List<Student>();
            using (StreamReader sr = new StreamReader(path, encoding: Encoding.GetEncoding(1251)))
>>>>>>> Work Project
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
<<<<<<< HEAD
                    Console.WriteLine(line);
                }
            }
            return Readfile();
        }  
    }
}
=======
                    string[] data = line.Split(' ');
                    students.Add(new Student(data[2], data[1], group, "KPI"));
                }
            }
            return students;
        }

        public static List<Student> GetStudentsFromGroup(string group)
        {
            string path = "D:\\Turniket_OOP/Turniket_OOP/" + group + ".txt";
            return ReadFile(path, group);
        }
    }
}
>>>>>>> Work Project
