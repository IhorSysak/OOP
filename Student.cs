using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turniket_OOP
{

    class Student
    {
        public Student(string Name, string Surname, string Group, string University)
        {
            name = Name;
            surname = Surname;
            group = Group;
            university = University;
        }

        private string name;
        private string surname;
        private string university;
        private string group;

        public string Name { get => name; }
        public string Surname { get => surname; }
        public string University { get => university; }
        public string Group { get => group; }
        public bool Compare(Student student)
        {
            if (name.Equals(student.Name) &&
                surname.Equals(student.Surname) &&
                group.Equals(student.Group) &&
                university.Equals(student.University))
            {
                return true;
            }
            return false;
        }
    }
}
