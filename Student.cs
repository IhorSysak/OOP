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
<<<<<<< HEAD
=======

>>>>>>> Work Project
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
<<<<<<< HEAD
=======


        public override bool Equals(Object o)
        {
            if (o == null || !(o is Student))
            {
                return false;
            }

            Student student = (Student)o;
            return this.name.Equals(student.Name) && this.surname.Equals(student.Surname);
        }

        public override int GetHashCode()
        {
            int hashcode = name == null ? name.GetHashCode() : 0;
            hashcode += surname == null ? surname.GetHashCode() : 0;
            return 31 * hashcode;
        }

        public override string ToString()
        {
            return surname + " " + name;
        }
>>>>>>> Work Project
    }
}
