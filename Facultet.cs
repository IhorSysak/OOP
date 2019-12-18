using System;
using System.Collections.Generic;
using System.IO;

namespace Turniket_OOP
{    static class Facultet
    {
        public static List<Student> Readfile() 
        {
            using (StreamReader sr = new StreamReader("group.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            return Readfile();
        }  
    }
}
