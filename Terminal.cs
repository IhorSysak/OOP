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
    }
}
