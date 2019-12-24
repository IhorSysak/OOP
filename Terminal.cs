using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turniket_OOP
{
    static class Terminal
    {
        //JSON
<<<<<<< HEAD
        public static void Validete(Student traspasser)
        {
            if(traspasser == null)
            {
                return;
            }

           foreach (Student student in Facultet.Readfile())
            {
                if (student.Compare(traspasser))
                {
                    Decanat.GetDecanat().Inform(traspasser);
                    break;
                }
            }
        }
=======
        public static bool Validete(Student traspasser)
        {
            if (traspasser == null)
            {
                return false;
            }

            string path = "D:\\Turniket_OOP/Turniket_OOP/" + traspasser.Group + ".txt";
            List<Student> students = Facultet.Students;
            return students.Contains(traspasser);
        } 
>>>>>>> Work Project
    }
}
