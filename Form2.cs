using System;
using System.Collections.Generic;
using System.ComponentModel;
<<<<<<< HEAD
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turniket_OOP
=======
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Turniket_OOP;
using System.Text.RegularExpressions;
using System.Threading;
using System.Drawing;

namespace OOP_Turniket
>>>>>>> Work Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
<<<<<<< HEAD
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 PrevForm = new Form1();
            PrevForm.Show();
        }
    }
}
=======
            InitializeTimer();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(220, 180);
        }

        private int counter;

        private void InitializeTimer()
        {
            // Run this procedure in an appropriate event.  
            counter = 0;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            // Hook up timer's tick event handler.  
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            if (counter >= 1000)
            {
                string path_present = "D:\\Turniket_OOP/Turniket_OOP/Present.txt";
                string path_late = "D:\\Turniket_OOP/Turniket_OOP/Late.txt";

                File.WriteAllText(path_present, String.Empty);
                File.WriteAllText(path_late, String.Empty);
                // Exit loop code.  
                timer1.Enabled = false;
                counter = 0;
            }
            else
            {
                // Run your procedure here.  
                // Increment counter.  
                counter = counter + 1;
                label1.Text = "Procedures Run: " + counter.ToString();
            }
        }

        private void button_Prev_Click(object sender, EventArgs e)
        {
            Form1 Prev_Form = new Form1();
            Prev_Form.Show();
            Hide();
        }

        private void button1_group1_Click(object sender, EventArgs e)
        {
            //HashCode
            if (listBox1.Text != " " || textBox_Mess2.Text != " ")
            {
                listBox1.Items.Clear();
                textBox_Mess2.Clear();
            }

            string group = "IS-81";
            GetStudentsFromGroupDate(group);
        }

        private void button1_group2_Click(object sender, EventArgs e)
        {
            if (listBox1.Text != " " || textBox_Mess2.Text != " ")
            {
                listBox1.Items.Clear();
                textBox_Mess2.Clear();
            }

            string group = "IS-82";
            GetStudentsFromGroupDate(group);


        }

        private void button1_Clear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox_Mess2.Clear();
        }

        private void button1_All_Click(object sender, EventArgs e)
        {
            if (listBox1.Text != " ")
            {
                listBox1.Items.Clear();
            }
            listBox1.Items.AddRange(File.ReadAllLines("D:\\Turniket_OOP/Turniket_OOP/groups.txt", encoding: Encoding.GetEncoding(1251)));
        }

        private void button_Sort_by_Missed_Click(object sender, EventArgs e)
        {
            string allPresent = File.ReadAllText("D:\\Turniket_OOP/Turniket_OOP/Present.txt", encoding: Encoding.GetEncoding(1251)) + "\n" +
                File.ReadAllText("D:\\Turniket_OOP/Turniket_OOP/Late.txt", encoding: Encoding.GetEncoding(1251));

            int countMissing = 1;

            try
            {
                string[] file_Missing = File.ReadAllLines("D:\\Turniket_OOP/Turniket_OOP/Missing.txt");
                countMissing = Convert.ToInt32(file_Missing[file_Missing.Length - 1].Split('.')[0]);
            }
            catch (Exception ex)
            {
            }

            using (StreamWriter fstream = new StreamWriter("D:\\Turniket_OOP/Turniket_OOP/Missing.txt", true, Encoding.GetEncoding(1251)))
            {
                foreach (Student student in Facultet.Students)
                {
                    //Decanat.GetDecanat().IsStudentLate();
                    if (!allPresent.Contains(student.ToString()))
                    {
                        //if (!missingText.Contains(student.ToString()))
                        //{
                        fstream.WriteLine(countMissing++ + ". " + student + " " + DateTime.Now.ToShortDateString());
                        //}
                    }
                }
            }

            if (listBox1.Text != " ")
            {
                listBox1.Items.Clear();
            }
            listBox1.Items.AddRange(File.ReadAllLines("D:\\Turniket_OOP/Turniket_OOP/Missing.txt", encoding: Encoding.GetEncoding(1251)));
        }

        private void button_Cheak_student_Click(object sender, EventArgs e)
        {
            /*string student = "D:\\Turniket_OOP/Turniket_OOP/Missing.txt";
            string regex = (@"[\d. ]*" + @"(?<name>[a-я A-Я]+)" + @"- [\d]+ пропусків, " + @"(?<date>\d{2}\.\d{2}\.\d{4})");
            Regex rgx = new Regex(regex);
            DateTime dt = dateTimePicker1.Value;
            Regex picker = new Regex(dt.ToString());*/

            int countMissing = 1;

            if (listBox1.Text != " " || textBox_Mess2.Text != " ")
            {
                listBox1.Items.Clear();
                textBox_Mess2.Clear();
            }

            string path = "D:\\Turniket_OOP/Turniket_OOP/Missing.txt";
            using (StreamReader sr = new StreamReader(path, encoding: Encoding.GetEncoding(1251)))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split(' ');
                    DateTime missingDate = DateTime.Parse(data[3]);
                    string dt = dateTimePicker1.Value.ToShortDateString();
                    if (dt == data[3])
                    {
                        data[0] = "" + countMissing + ".";
                        countMissing++;
                        line = "";
                        foreach (String str in data)
                        {
                            line += str + " ";
                        }
                        listBox1.Items.Add(line);
                    }
                    else
                    {
                        textBox_Mess2.Text = "Спільного не знайдено";
                    }
                }

            }
        }

        private void button_Clear_file_Click(object sender, EventArgs e)
        {
            //public void cheak_time()
            //{
            //int hour = 01;
            //int minute = 42;
            //int second = 00;
            //if (hour == DateTime.Now.Hour && minute == DateTime.Now.Minute && second == DateTime.Now.Second)
            //{
            string path_present = "D:\\Turniket_OOP/Turniket_OOP/Present.txt";
            string path_late = "D:\\Turniket_OOP/Turniket_OOP/Late.txt";

            File.WriteAllText(path_present, String.Empty);
            File.WriteAllText(path_late, String.Empty);
            //}
            //}
        }

        private List<Student> GetStudentsFromGroupDate(string group)
        {
            List<Student> students = Facultet.GetStudentsFromGroup(group);
            string path = "D:\\Turniket_OOP/Turniket_OOP/Missing.txt";
            int countMissing = 1;

            using (StreamReader sr = new StreamReader(path, encoding: Encoding.GetEncoding(1251)))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    foreach (Student student in students)
                    {
                        if (!line.Contains(student.ToString()))
                            continue;

                        string[] data = line.Split(' ');
                        DateTime missingDate = DateTime.Parse(data[3]);
                        string dt = dateTimePicker1.Value.ToShortDateString();
                        if (dt == data[3])
                        {
                            data[0] = "" + countMissing + ".";
                            countMissing++;
                            line = "";
                            foreach (String str in data)
                            {
                                line += str + " ";
                            }
                            listBox1.Items.Add(line);
                        }
                        else 
                        {
                            textBox_Mess2.Text = "Спільного не знайдено";
                        }
                    }
                }
                return students;
            }
        }

        private void button_Late_Student_Click(object sender, EventArgs e)
        {
            if (listBox1.Text != " ")
            {
                listBox1.Items.Clear();
            }
            listBox1.Items.AddRange(File.ReadAllLines("D:\\Turniket_OOP/Turniket_OOP/Late.txt", encoding: Encoding.GetEncoding(1251)));
        }

        private void button_Present_Student_Click(object sender, EventArgs e)
        {
            if (listBox1.Text != " ")
            {
                listBox1.Items.Clear();
            }
            listBox1.Items.AddRange(File.ReadAllLines("D:\\Turniket_OOP/Turniket_OOP/Present.txt", encoding: Encoding.GetEncoding(1251)));
        }

        private void button_Found_Student_Click(object sender, EventArgs e)
        {
            int countMissing = 1;

            if (listBox1.Text != " " || textBox_Mess2.Text != " ")
            {
                listBox1.Items.Clear();
                textBox_Mess2.Clear();
            }

            string path = "D:\\Turniket_OOP/Turniket_OOP/Missing.txt";
            using (StreamReader sr = new StreamReader(path, encoding: Encoding.GetEncoding(1251)))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split(' ');
                    //DateTime missingDate = DateTime.Parse(data[3]);
                    string text = textBox_Found_Student.Text;
                    //string dt = dateTimePicker1.Value.ToShortDateString();
                    string line1;
                    line1 = data[1] + " " + data[2];

                    if (text == line1)
                    {
                        data[0] = "" + countMissing + ".";
                        countMissing++;
                        line = "";
                        foreach (String str in data)
                        {
                            line += str + " ";
                        }
                        listBox1.Items.Add(line);
                    }
                    else
                    {
                        textBox_Mess2.Text = "Спільного не знайдено";
                    }
                }

            }
        }
    }
}
>>>>>>> Work Project
