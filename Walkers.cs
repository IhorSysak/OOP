using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turniket_OOP;
using System.IO;

namespace OOP_Turniket
{
    class Walkers
    {
        private static Walkers walkers = null;
        private Walkers() 
        {
            
            string[] file_Present = File.ReadAllLines("D:\\Turniket_OOP/Turniket_OOP/Present.txt");
            string[] file_Late = File.ReadAllLines("D:\\Turniket_OOP/Turniket_OOP/Late.txt");


            try
            {
                countPresent = Convert.ToInt32(file_Present[file_Present.Length - 1].Split('.')[0]);
            }
            catch (Exception e)
            {
                countPresent = 0;
            }

            try
            {
                countLate = Convert.ToInt32(file_Late[file_Late.Length - 1].Split('.')[0]);
            }
            catch (Exception e)
            {
                countLate = 0;
            }
        }

        public static Walkers GetWalkers()
        {
            if (walkers == null)
            {
                walkers = new Walkers();
            }
            return walkers;
        }

        public Walkers(string Name, string Surname, int Quantity)
        {
            name = Name;
            surname = Surname;
            quantity = Quantity;
        }

        private string name;
        private string surname;
        private int quantity;

        public string Name { get => name; }
        public string Surname { get => surname; }
        public int Quantity { get => quantity; }

        int countPresent = 1;
        int countLate = 1;

        public void Inform(Student student, bool Islate, int walk)
        {
            // Clear text file, if a new day
            // Number_lessons ++
            // Cheak in 6 pm hours- cheak student in text file
            if (Islate) //pars
            {
                try
                {
                    string[] file_Missing = File.ReadAllLines("D:\\Turniket_OOP/Turniket_OOP/Present.txt");
                    countPresent = Convert.ToInt32(file_Missing[file_Missing.Length - 1].Split('.')[0]);
                }
                catch (Exception ex)
                {
                }

                string presentText = File.ReadAllText("D:\\Turniket_OOP/Turniket_OOP/Present.txt", encoding: Encoding.GetEncoding(1251));
                if (presentText.Contains(student.ToString()))
                {
                    return;
                }

                using (StreamWriter fstream = new StreamWriter("D:\\Turniket_OOP/Turniket_OOP/Present.txt", true, Encoding.GetEncoding(1251)))
                {
                    countPresent++;
                    fstream.WriteLine(countPresent + ". " + student + " - " + DateTime.Now);
                }
            }
            else
            {
                try
                {
                    string[] file_Missing = File.ReadAllLines("D:\\Turniket_OOP/Turniket_OOP/Late.txt");
                    countLate = Convert.ToInt32(file_Missing[file_Missing.Length - 1].Split('.')[0]);
                }
                catch (Exception ex)
                {
                }

                string lateText = File.ReadAllText("D:\\Turniket_OOP/Turniket_OOP/Late.txt", encoding: Encoding.GetEncoding(1251));
                if (lateText.Contains(student.ToString()))
                {
                    return;
                }

                using (StreamWriter fstream = new StreamWriter("D:\\Turniket_OOP/Turniket_OOP/Late.txt", true, Encoding.GetEncoding(1251)))
                {
                    countLate++;
                    fstream.WriteLine(countLate + ". " + student + " " + walk + " - " + "пропусків" + " " + DateTime.Now.ToShortDateString());

                }
            }
        }

    }
}